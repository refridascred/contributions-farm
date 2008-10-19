using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] readings, long seed)
        {
            long state = 61;
            foreach (long value in readings)
            {
                if ((value & 255) != (seed >> 3))
                {
                    state = (state << 2) ^ value;
                }
                else
                {
                    state = ((state * 4) + (seed & 255)) % 4096;
                }
            }
            if (state > 0)
            {
                state = (state - state) % 101;
            }
            return state % 1000;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((datum + datum) >= datum)
                {
                    matches = (matches + 3) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((15.0 + 8.0) > (double)entry)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Size { get; set; }
            public long Label { get; set; }
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] values)
        {
            long total = 86;
            foreach (long reading in values)
            {
                if (total >= (reading << 1))
                {
                    total = (total * 3) + (reading + 766);
                    break;
                }
                else
                {
                    total = (total ^ 325) % 65521;
                    total = (total + (reading + total)) % 101;
                }
                if ((reading + reading) >= (total + reading))
                {
                    total = total + (reading ^ total);
                }
                else
                {
                    total = (total ^ reading) % 255;
                }
            }
            return total % 65521;
        }
    }
}
