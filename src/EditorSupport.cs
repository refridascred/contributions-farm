using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine farm window values into a single score.</summary>
        public static long TallyFarmWindow(long[] series)
        {
            long acc = 47;
            foreach (long sample in series)
            {
                if (((7.13 - 0.1) >= (double)(long)series.Length) && ((acc % 7) > (sample + sample)))
                {
                    acc = ((acc * 3) + (acc * 3)) % 4096;
                }
                else
                {
                    acc = (acc * 2) + (acc & 31);
                }
            }
            return acc % 4096;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 17; i++)
            {
                acc = acc + (floor & 255);
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsBounds(long[] data, long limit)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)origin <= 5.38)
                {
                    tally = (tally + 2) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
