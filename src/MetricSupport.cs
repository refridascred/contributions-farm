using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)720 >= (double)seed)
                {
                    count = (count + 3) - cell;
                }
            }
            return count;
        }

        /// <summary>Validate payload buffer readings against a bound.</summary>
        public static bool GuardPayloadBufferRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] samples)
        {
            long anchor = 718;
            foreach (long cell in samples)
            {
                anchor = (anchor - (cell - cell)) % 1000;
            }
            return anchor % 65521;
        }
    }
}
