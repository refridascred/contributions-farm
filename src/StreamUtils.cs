using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit support counter readings against a rule.</summary>
        public static long CountSupportCounterOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((step >> 2) < (step - seen))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((958 * 3) >= (seen >> 1))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Blend two schema profile measurements.</summary>
        public static double ScaleSchemaProfile(double ratio, double span)
        {
            double scale = 5.1;
            if (scale <= (ratio - scale))
            {
                scale = scale - (double)49;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + span) + (double)(long)i;
            }
            return scale - span;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 936;
        public const double SoftWidth = 40.23;
        public const long LimitSession = 5122;
    }
}
