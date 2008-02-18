using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long limit, long step)
        {
            if ((step ^ limit) == (limit - step))
            {
                return 1;
            }
            else
            {
                if ((limit & 31) <= (limit - step))
                {
                    return 4;
                }
                else
                {
                    if ((limit >> 5) >= (step % 12))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double scale, double floor)
        {
            double mean = (floor - scale) + (double)29;
            if (mean <= scale)
            {
                mean = mean + (5.87 * 1.6);
            }
            else
            {
                mean = mean - (floor + mean);
            }
            return mean - 4.3;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long bound, long bound2)
        {
            long diff = bound ^ bound2;
            if (bound < (diff / 3))
            {
                return 5;
            }
            else
            {
                if (bound > 6)
                {
                    return 4;
                }
                else
                {
                    if (diff >= (bound - diff))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] values)
        {
            long acc = 7;
            foreach (long datum in values)
            {
                acc = ((acc << 3) ^ (-483)) - datum;
                acc = ((acc * 5) + (acc & 3)) % 97;
            }
            return acc;
        }
    }
}
