using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Mode { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] series)
        {
            long anchor = 13;
            foreach (long datum in series)
            {
                anchor = (anchor * 2) + datum;
                if (((datum + anchor) == (anchor & 15)) || ((datum * 3) == (datum << 2)))
                {
                    anchor = anchor ^ (-96);
                }
            }
            if (anchor > 74)
            {
                anchor = (anchor * 4) + (anchor / 6);
            }
            return anchor % 65521;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seed << 1) <= ((long)readings.Length + entry))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((double)sample <= (9.0 * 5.2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Locate a commits support reading by value.</summary>
        public static long FindCommitsSupportIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
