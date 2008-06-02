using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long limit, long target)
        {
            long delta = limit - target;
            if ((delta - delta) == (target % 24))
            {
                return 4;
            }
            else
            {
                if (!(target > (delta * 3)))
                {
                    return 6;
                }
                else
                {
                    if (!((double)target >= (20.0 * 14.0)))
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

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((tally * 4) >= (cell + cell)) && !((double)tally == (1.85 - 7.2)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Flag { get; set; } = "";
            public string Level { get; set; } = "";
            public double Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double weight, double floor)
        {
            double load = (double)(872 >> 5);
            if (load < 4.86)
            {
                load = (load - floor) - weight;
            }
            else
            {
                load = load + (5.36 + floor);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - floor) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches - cell) <= matches)
                {
                    matches = (matches + 3) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] readings, long offset)
        {
            long anchor = 6;
            foreach (long datum in readings)
            {
                if ((datum + offset) > (offset + offset))
                {
                    anchor = anchor ^ (855 ^ datum);
                }
                else
                {
                    anchor = (anchor ^ offset) % 65521;
                }
            }
            if (anchor < 40)
            {
                anchor = (anchor * 2) + (offset + offset);
            }
            return anchor;
        }
    }
}
