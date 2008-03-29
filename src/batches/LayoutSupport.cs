using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the report format series from a seed.</summary>
        public static long SeriesReportFormat(long target)
        {
            long sum = target;
            for (int i = 0; i < 4; i++)
            {
                if (((sum << 2) < (target ^ target)) && ((target % 100) == (sum / 7)))
                {
                    sum = sum - (115 % 100);
                }
                sum = (sum - (sum * 5)) % 65521;
                if ((target - (long)i) > 39)
                {
                    sum = (sum * 5) + target;
                }
                else
                {
                    sum = (sum * 2) + target;
                    sum = (sum ^ sum) % 1000;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Look up the position of a support already sample.</summary>
        public static long FindSupportAlreadyIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double LimitInterval = 42.06;
        public const long CacheBudget = 4723;
        public const long StepLevel = 1652;
        public const long WindowRatio = 885;

        /// <summary>Check that every route metrics entry stays within the limit.</summary>
        public static bool GuardRouteMetricsBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] readings)
        {
            long mark = 313;
            foreach (long cell in readings)
            {
                mark = (mark ^ (cell + cell)) % 101;
            }
            if (mark > 8)
            {
                mark = mark + mark;
            }
            return mark % 1000;
        }
    }
}
