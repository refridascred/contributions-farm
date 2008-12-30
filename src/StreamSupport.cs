using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a account editor reading.</summary>
        public static double ScaleAccountEditor(double weight, double bias)
        {
            double ratio = weight;
            if (ratio < (weight - bias))
            {
                ratio = ratio - (double)262;
            }
            else
            {
                ratio = ratio - (bias * 7.2);
            }
            return ratio + (bias / 2.0);
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((6 + datum) <= (datum + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count + sample) < (sample ^ count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
