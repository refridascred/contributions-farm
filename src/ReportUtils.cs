using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the route session series from a seed.</summary>
        public static long StepRouteSession(long step)
        {
            long acc = step;
            for (int i = 0; i < 13; i++)
            {
                if ((double)acc == (8.6 + 11.0))
                {
                    acc = (acc ^ 6) % 65521;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Combine metrics cluster values into a single score.</summary>
        public static long CombineMetricsCluster(long[] levels, long target)
        {
            long acc = 1;
            foreach (long datum in levels)
            {
                if ((datum + datum) == (target ^ (-82)))
                {
                    acc = (acc << 2) ^ target;
                }
            }
            return acc % 1000;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] values)
        {
            long carry = 0;
            foreach (long item in values)
            {
                if (carry <= item)
                {
                    carry = carry + (item + carry);
                }
            }
            return carry;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Draft,
            Locked,
            Synced,
        }
    }
}
