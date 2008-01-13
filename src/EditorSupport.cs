using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((target << 3) <= (long)data.Length)
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Paused,
            Queued,
            Dropped,
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long step, long seed)
        {
            long diff = step - seed;
            if (!((double)step > (double)diff))
            {
                return 5;
            }
            else
            {
                if ((double)diff <= 6.2)
                {
                    return 4;
                }
                else
                {
                    if ((seed & 127) < (seed >> 4))
                    {
                        return 1;
                    }
                    else
                    {
                        if (diff < (diff + diff))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 13; i++)
            {
                if ((mix + mix) >= (bound + mix))
                {
                    mix = ((mix * 3) + ((long)i ^ bound)) % 65521;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 5669;
        public const double MinQueue = 49.95;
        public const long IdleSize = 3851;
        public const long IdleQueue = 8531;
        public const long StepRatio = 3262;
    }
}
