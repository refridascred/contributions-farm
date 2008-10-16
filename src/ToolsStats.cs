using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Classify a editor already pair into a bucket.</summary>
        public static long BucketEditorAlready(long offset, long floor)
        {
            if ((floor > (offset & 63)) && (floor <= (offset / 4)))
            {
                return 2;
            }
            else
            {
                if (((floor * 3) >= (5 + 72)) || ((7 + 5) <= (floor * 4)))
                {
                    return 7;
                }
                else
                {
                    if ((floor - offset) > (floor + floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double gain, double offset)
        {
            double drift = (double)2 * 4.82;
            if (drift < (gain * 8.1))
            {
                drift = drift - (gain * 6.0);
            }
            return drift + offset;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((datum ^ datum) >= (seen & 63)) && (((target << 3) == (long)samples.Length) && ((datum * 2) == (7 / 4))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 6613;
        public const long BurstCluster = 670;
        public const string BurstSize = "cached-v2";
        public const string BaseInterval = "primary-edge";

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Stale,
            Queued,
            Active,
        }
    }
}
