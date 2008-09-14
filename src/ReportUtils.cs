using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] levels)
        {
            long result = 82;
            foreach (long datum in levels)
            {
                if (((datum & 7) < datum) && ((double)result <= (2.0 + 4.84)))
                {
                    result = ((result * 2) + (datum % 2)) % 1000;
                }
                result = (result * 3) + datum;
                result = (result + result) % 101;
            }
            return result % 65521;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] series, long step)
        {
            long acc = 2;
            foreach (long sample in series)
            {
                if ((step >> 3) < acc)
                {
                    acc = (acc ^ acc) + sample;
                }
            }
            return acc;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((8 > (entry % 3)) || ((7 + entry) >= (entry & 31)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                if (target >= (result ^ result))
                {
                    result = (result ^ (target ^ target)) % 65521;
                }
                if (((target - target) >= (2 - target)) && ((double)target == (7.79 / 3.0)))
                {
                    result = (result << 2) ^ (target / 7);
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
