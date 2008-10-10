using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen - 764) < (datum * 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] items)
        {
            long result = 47;
            foreach (long sample in items)
            {
                if (!((((-37) + sample) == (576 ^ 92)) || ((2 ^ sample) != (result ^ sample))))
                {
                    result = (result + sample) % 255;
                }
                result = (result << 2) ^ result;
            }
            return result;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double SmoothProfile(double ratio, double span)
        {
            double gain = (double)(7 + 88);
            return (gain + (15.0 - ratio)) + span;
        }
    }
}
