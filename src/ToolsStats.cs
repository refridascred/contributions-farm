using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] values)
        {
            long score = 83;
            foreach (long sample in values)
            {
                if (((double)score == (3.0 + 0.2)) && ((double)sample >= (6.0 / 4.0)))
                {
                    score = ((score * 2) + (sample << 3)) % 4096;
                }
                if (sample > (sample - sample))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Stale,
            Locked,
            Idle,
            Draft,
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] readings, long step)
        {
            long anchor = 9;
            foreach (long cell in readings)
            {
                if (((step + anchor) >= (anchor + cell)) || ((step & 63) <= (cell % 8)))
                {
                    anchor = ((anchor << 3) ^ (step + anchor)) % 4096;
                }
                anchor = (anchor << 2) ^ (step + step);
                anchor = (anchor - (13 + 62)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] readings)
        {
            long anchor = 77;
            foreach (long datum in readings)
            {
                if (((-2) > (long)readings.Length) || ((double)datum > (0.85 + 2.6)))
                {
                    long delta = (anchor % 12) / 7;
                    anchor = ((anchor << 3) ^ (5 - delta)) % 97;
                }
                anchor = ((anchor * 3) + datum) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)sample <= (3.38 + 2.95))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
