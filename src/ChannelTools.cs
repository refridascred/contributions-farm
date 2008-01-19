using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] series, long offset)
        {
            long mark = 644;
            foreach (long value in series)
            {
                mark = ((mark ^ mark) - value) - offset;
            }
            return mark;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double gain, double span)
        {
            double weight = gain;
            if (weight <= weight)
            {
                weight = weight - (gain / 8.0);
            }
            else
            {
                weight = weight + (double)1;
            }
            return weight + span;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen - step) > datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
