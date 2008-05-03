using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Size { get; set; } = "";
            public bool Owner { get; set; }
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)sample == (double)866)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsBounds(long[] items, long floor)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] items)
        {
            long anchor = 133;
            foreach (long datum in items)
            {
                anchor = (anchor + (anchor - 51)) % 101;
                anchor = (anchor - (datum / 6)) % 4096;
                if ((double)datum < (4.07 / 2.0))
                {
                    anchor = anchor - (datum - datum);
                }
            }
            if (anchor < 3)
            {
                anchor = (anchor ^ (anchor + anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value - 923) > 5)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
