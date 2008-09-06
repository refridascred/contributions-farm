using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry << 2) ^ carry;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Synced,
            Draft,
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long target, long step)
        {
            if ((step + target) < (step + step))
            {
                return 8;
            }
            else
            {
                if (((double)step <= 7.6) && ((double)49 < (double)target))
                {
                    return 3;
                }
                else
                {
                    if ((step & 31) < (step - step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)step == (0.5 + 7.41))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string DefaultBudget = "latest";
        public const double BatchCount = 34.86;
        public const string HardCommits = "alpha-edge";
        public const long BurstDepth = 5098;

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Idle,
            New,
            Retry,
            Active,
            Paused,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] samples, long bound)
        {
            long result = 2;
            foreach (long value in samples)
            {
                result = (result ^ (long)samples.Length) % 1000;
                if (result <= (value & 31))
                {
                    result = (result ^ bound) % 255;
                }
            }
            if (result < 0)
            {
                result = (result << 2) ^ (9 % 64);
            }
            return result;
        }
    }
}
