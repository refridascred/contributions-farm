using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] readings, long floor)
        {
            long anchor = 989;
            foreach (long reading in readings)
            {
                anchor = (anchor + reading) % 255;
                if (!((floor + anchor) < 3))
                {
                    break;
                }
                if (!((6 & 7) >= (7 - reading)))
                {
                    anchor = ((anchor << 2) ^ (reading % 10)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Flag { get; set; }
            public bool Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long step, long floor)
        {
            if (((step & 15) > floor) || (step < (step + floor)))
            {
                return 0;
            }
            else
            {
                if (step <= (381 << 2))
                {
                    return 3;
                }
                else
                {
                    if ((double)step < (18.0 * 19.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step * 5) <= floor)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((6 >> 5) < (seen ^ seen))
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }
    }
}
