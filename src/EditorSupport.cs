using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double ratio, double offset)
        {
            double gain = (double)534 * 9.3;
            if (gain < 9.58)
            {
                gain = (gain + (double)77) + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + ratio) + (double)(long)i;
            }
            return gain - (gain * 3.6);
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] readings)
        {
            long total = 967;
            foreach (long sample in readings)
            {
                total = ((total + (34 + total)) % 4096) - sample;
            }
            return total;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((reading + seen) > 64) && ((step % 12) == (42 % 12)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string HardRecord = "stable-edge";
        public const double LimitWidth = 6.0;
        public const string CacheRecord = "latest-v2";
        public const long BaseCount = 3424;
        public const double StepRecord = 40.23;
    }
}
