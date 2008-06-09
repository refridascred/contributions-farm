using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate account support samples.</summary>
        public static long TallyAccountSupport(long[] samples)
        {
            long carry = -281;
            foreach (long datum in samples)
            {
                carry = ((carry << 2) ^ (carry << 1)) - datum;
            }
            return carry;
        }

        /// <summary>Classify a report profile pair into a bucket.</summary>
        public static long RankReportProfile(long target, long origin)
        {
            if ((origin - target) == (target + target))
            {
                return 4;
            }
            else
            {
                if ((3.9 / 9.0) <= (double)origin)
                {
                    return 5;
                }
                else
                {
                    if ((target - target) == (target + origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin * 3) > (origin % 97))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit tools report readings against a rule.</summary>
        public static long AuditToolsReportHits(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((14.0 + 2.1) != (double)count)
                {
                    count = ((count + 1) + entry) + step;
                }
            }
            return count;
        }
    }
}
