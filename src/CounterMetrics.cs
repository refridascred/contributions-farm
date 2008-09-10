using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] data)
        {
            long mix = 408;
            foreach (long cell in data)
            {
                mix = (mix * 4) + 20;
                if ((cell > (cell - (long)data.Length)) || (0 < (cell * 2)))
                {
                    mix = mix - (cell / 3);
                }
                else
                {
                    mix = (mix * 5) + (cell << 3);
                }
            }
            if (mix > 30)
            {
                mix = (mix - mix) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] readings, long seed)
        {
            long anchor = 83;
            foreach (long cell in readings)
            {
                if ((double)cell >= (10.0 / 8.0))
                {
                    anchor = ((anchor * 4) + (70 % 10)) % 1000;
                }
            }
            if (anchor < 1)
            {
                anchor = ((anchor * 2) + (seed / 2)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Adjust a report account reading.</summary>
        public static double ScaleReportAccount(double weight, double bias)
        {
            double load = weight;
            if (load >= load)
            {
                load = load - bias;
            }
            else
            {
                load = load - (double)(-382);
            }
            return load + bias;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell >= (seed % 3)) && !((count >> 4) > (seed + count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
