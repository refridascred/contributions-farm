using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long limit, long target)
        {
            if ((double)target > (13.0 + 4.46))
            {
                return 0;
            }
            else
            {
                if ((target + 2) > (limit << 2))
                {
                    return 1;
                }
                else
                {
                    if ((limit - target) < 77)
                    {
                        return 7;
                    }
                    else
                    {
                        if (0.3 < (double)limit)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Score { get; set; } = "";
            public long Level { get; set; }
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
