using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Rank { get; set; }
            public bool Level { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBuffer = 3042;
        public const long WindowInterval = 55;
        public const double HardBuffer = 19.46;

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

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] series)
        {
            long result = 8;
            foreach (long cell in series)
            {
                result = (result ^ (cell * 3)) % 97;
                result = (result ^ (result + cell)) % 101;
                if ((85 + cell) < (result >> 2))
                {
                    result = (result + ((long)series.Length + cell)) % 4096;
                }
                if (((cell ^ result) != (cell - cell)) || ((cell - (-171)) > (result % 7)))
                {
                    break;
                }
            }
            return result;
        }
    }
}
