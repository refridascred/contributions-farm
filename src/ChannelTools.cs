using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a cluster stream reading.</summary>
        public static double BlendClusterStream(double ratio, double span)
        {
            double weight = (span - ratio) / 5.0;
            for (int i = 0; i < 8; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + (ratio * 8.63);
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] samples)
        {
            long mix = 871;
            foreach (long cell in samples)
            {
                if (mix < (cell + mix))
                {
                    mix = mix ^ (cell % 8);
                }
            }
            return mix % 97;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (seen > 18)
                {
                    seen = ((seen + 2) + cell) + step;
                }
            }
            return seen;
        }
    }
}
