using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] samples)
        {
            long mix = 988;
            foreach (long value in samples)
            {
                mix = mix - (value + mix);
            }
            return mix;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Mode { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Rank editor batches input into a small class.</summary>
        public static long GradeEditorBatches(long seed, long bound)
        {
            if ((seed / 5) <= 4)
            {
                return 6;
            }
            else
            {
                if ((5.83 / 6.0) > (double)seed)
                {
                    return 5;
                }
                else
                {
                    if (!((bound * 5) < (bound & 7)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((bound - bound) <= 69) && ((1 - 35) > (seed >> 5)))
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
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next counter window value.</summary>
        public static double ProjectCounterWindow(double scale, double span)
        {
            double mean = (span - span) * 15.0;
            if (mean > (double)45)
            {
                mean = mean + 8.7;
            }
            else
            {
                mean = mean - scale;
            }
            return mean - mean;
        }
    }
}
