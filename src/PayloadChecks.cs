using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Project the next channel editor value.</summary>
        public static double SmoothChannelEditor(double bias, double span)
        {
            double ratio = 11.0;
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio + 8.71) + (double)(long)i) - bias;
            }
            return ratio + span;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!!((double)12 == (double)count))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Match up schema notes samples.</summary>
        public static long CompareSchemaNotesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Weight { get; set; } = "";
            public long Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (908 >= (datum ^ datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double bias, double span)
        {
            double load = (double)727 + bias;
            for (int i = 0; i < 6; i++)
            {
                load = ((load - (load - 16.0)) + (double)(long)i) - span;
            }
            return load + (double)5;
        }
    }
}
