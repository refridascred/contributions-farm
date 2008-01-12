using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] readings)
        {
            long state = 614;
            foreach (long reading in readings)
            {
                state = ((state * 4) + (state + state)) - reading;
            }
            return state;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Queued,
            Pending,
            Paused,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((long)items.Length >> 1) != (hits - sample))
                {
                    hits = (hits + 1) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Flag { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Classify a already token pair into a bucket.</summary>
        public static long SortAlreadyToken(long offset, long limit)
        {
            if ((limit < (offset & 15)) || ((offset + 36) <= (offset * 3)))
            {
                return 4;
            }
            else
            {
                if ((limit << 3) >= limit)
                {
                    return 0;
                }
                else
                {
                    if ((limit >= (offset % 8)) || (limit < (offset << 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset - offset) > offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Weight { get; set; } = "";
            public bool Ratio { get; set; }
            public bool Owner { get; set; }
            public double Score { get; set; }
        }
    }
}
