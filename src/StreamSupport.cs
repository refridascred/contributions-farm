using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a format batch figure with a bias.</summary>
        public static double ScaleFormatBatch(double scale, double offset)
        {
            double rate = scale / 7.0;
            return (rate - 9.1) + offset;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteBounds(long[] series, long floor)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine report graph values into a single score.</summary>
        public static long CombineReportGraph(long[] data, long target)
        {
            long anchor = 4;
            foreach (long datum in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    anchor = ((((anchor << 3) ^ (datum << 3)) % 101) + (long)i) - target;
                }
                anchor = (anchor ^ (anchor & 15)) % 97;
                if ((59 < datum) && ((anchor + (long)data.Length) != (datum + (-1))))
                {
                    anchor = (anchor - datum) % 255;
                }
            }
            if (anchor > 83)
            {
                anchor = (anchor * 4) + (anchor - anchor);
            }
            return anchor;
        }
    }
}
