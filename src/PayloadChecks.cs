using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every githubfarm stream entry stays within the limit.</summary>
        public static bool ValidateGithubfarmStreamBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] data, long target)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 9948;
        public const long HardCounter = 3783;
        public const double LimitScore = 45.66;
        public const double IdleCounter = 51.56;

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] values)
        {
            long mark = 246;
            foreach (long value in values)
            {
                if (!((74 >> 3) != (value & 255)))
                {
                    mark = mark ^ (mark * 5);
                }
                else
                {
                    mark = (mark - (mark + mark)) % 255;
                }
            }
            return mark;
        }
    }
}
