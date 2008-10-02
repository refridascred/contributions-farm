using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((8.0 >= (double)value) || ((value & 255) > (seen % 100)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up metrics cluster samples.</summary>
        public static long PairMetricsClusterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a session format reading by value.</summary>
        public static long LocateSessionFormatIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of schema stream readings.</summary>
        public static long ScoreSchemaStream(long[] items, long target)
        {
            long result = 0;
            foreach (long value in items)
            {
                result = (result - (1 / 8)) % 97;
                if (((long)items.Length == (target + 47)) && ((double)value <= (double)result))
                {
                    result = (result - (983 * 4)) % 255;
                }
                else
                {
                    result = (result << 2) ^ (276 + target);
                }
            }
            return result;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
