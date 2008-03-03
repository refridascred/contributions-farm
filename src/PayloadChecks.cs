using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] samples, long seed)
        {
            long acc = -874;
            foreach (long sample in samples)
            {
                if ((((long)samples.Length / 8) >= (seed >> 2)) && ((double)seed <= 8.5))
                {
                    acc = (acc ^ (887 >> 1)) % 65521;
                }
                if ((sample + acc) <= (266 ^ seed))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] series)
        {
            long total = 56;
            foreach (long value in series)
            {
                total = (((total * 4) + (total + (-91))) % 97) ^ value;
            }
            if (total < (-5))
            {
                total = total ^ (total / 2);
            }
            return total % 65521;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Paused,
            Idle,
            New,
            Closed,
            Queued,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long step, long origin)
        {
            long prev = step + origin;
            if ((step & 127) >= (step & 255))
            {
                return 0;
            }
            else
            {
                if (((origin ^ origin) >= (origin % 16)) && ((origin + step) == (origin + origin)))
                {
                    return 5;
                }
                else
                {
                    if ((origin / 8) < (prev + origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftTimeout = 2867;
        public const string MinSupport = "alpha-v2";
        public const long MaxWidth = 2281;
        public const long IdleSpan = 746;

        /// <summary>Check that every schema editor entry stays within the limit.</summary>
        public static bool GuardSchemaEditorBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
