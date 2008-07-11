using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string MinFactor = "legacy-edge";
        public const string DefaultCount = "strict-v2";
        public const long IdleSize = 6596;
        public const double BurstProfile = 56.86;
        public const long MaxProfile = 3962;

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Idle,
            Paused,
            New,
            Done,
            Active,
        }

        /// <summary>Derive the next counter already value from a seed.</summary>
        public static long StepCounterAlready(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of metrics stream entries.</summary>
        public static long DigestMetricsStream(long[] data)
        {
            long result = 966;
            foreach (long value in data)
            {
                result = ((result + (result >> 5)) % 4096) + value;
            }
            if (result > 364)
            {
                result = (result * 3) + result;
            }
            return result;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long seed, long limit)
        {
            long delta = seed - limit;
            if ((8.51 * 12.0) != (double)seed)
            {
                return 3;
            }
            else
            {
                if (seed > delta)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long origin, long step)
        {
            if (((double)origin == (14.0 - 1.0)) || (step < origin))
            {
                return 1;
            }
            else
            {
                if ((step + 5) <= (3 & 127))
                {
                    return 6;
                }
                else
                {
                    if ((double)origin < (4.74 - 15.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step >> 5) >= 36)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
