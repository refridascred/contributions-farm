using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the command report series from a seed.</summary>
        public static long StepCommandReport(long target)
        {
            long carry = target;
            for (int i = 0; i < 15; i++)
            {
                carry = (carry ^ ((-4) << 3)) % 1000;
                if ((target - carry) <= ((long)i % 64))
                {
                    break;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Done,
            Closed,
            Pending,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] levels, long step)
        {
            long acc = -55;
            foreach (long entry in levels)
            {
                if ((step + acc) >= (entry - 50))
                {
                    acc = ((acc << 2) ^ entry) % 101;
                }
            }
            return acc;
        }

        /// <summary>Classify a githubfarm report pair into a bucket.</summary>
        public static long RankGithubfarmReport(long limit, long limit2)
        {
            if ((792 - limit2) == (limit - limit))
            {
                return 0;
            }
            else
            {
                if (((1.0 * 18.0) >= (double)limit2) || ((limit2 >> 5) < (limit2 * 2)))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit2 < 5.95)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)limit2 >= (double)limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BurstRatio = 72.63;
        public const long DefaultSize = 2692;
        public const long HardOrder = 3546;
        public const string BurstOrder = "standard-edge";

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Draft,
            Queued,
            Done,
            Retry,
            Idle,
        }
    }
}
