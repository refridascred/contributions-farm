using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Match up farm account samples.</summary>
        public static long CompareFarmAccountCount(long[] levels)
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

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((seen ^ reading) > 5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many buffer editor samples are out of range.</summary>
        public static long CountBufferEditorHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (seen > (entry + entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
