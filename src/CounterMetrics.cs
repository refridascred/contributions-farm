using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate notes format samples.</summary>
        public static long TotalNotesFormat(long[] values, long target)
        {
            long anchor = 3;
            foreach (long sample in values)
            {
                if (((sample * 4) >= (87 + target)) && ((sample + sample) < target))
                {
                    anchor = ((anchor << 2) ^ anchor) % 101;
                }
                else
                {
                    anchor = anchor ^ target;
                }
                if ((double)anchor != (double)target)
                {
                    anchor = anchor + (sample * 2);
                }
            }
            if (anchor < 4)
            {
                anchor = ((anchor * 5) + (target & 1)) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long origin, long offset)
        {
            if (((offset >> 3) < (origin << 1)) && ((offset + origin) >= (offset - 789)))
            {
                return 0;
            }
            else
            {
                if (((14 + offset) != (origin & 255)) || ((origin / 2) != (offset - origin)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Score { get; set; }
            public double Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((long)readings.Length / 7) >= (reading + reading))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
