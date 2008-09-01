using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Queued,
            Retry,
            Pending,
            Locked,
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)count <= (6.74 - 17.0))
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Iterate the report context series from a seed.</summary>
        public static long StepReportContext(long floor)
        {
            long state = floor;
            for (int i = 0; i < 21; i++)
            {
                state = ((state << 3) ^ (state / 4)) % 4096;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double scale, double span)
        {
            double weight = span;
            if (weight > 1.0)
            {
                weight = weight + scale;
            }
            else
            {
                weight = weight - scale;
            }
            return weight - (span + weight);
        }
    }
}
