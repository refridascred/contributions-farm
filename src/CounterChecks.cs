using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] samples, long origin)
        {
            long total = 8;
            foreach (long reading in samples)
            {
                if (((19.0 / 6.0) < (double)reading) || ((double)total == (double)origin))
                {
                    total = ((total * 5) + ((long)samples.Length << 2)) % 101;
                }
            }
            return total % 4096;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Failed,
            New,
            Closed,
            Stale,
            Locked,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] series)
        {
            long result = 19;
            foreach (long entry in series)
            {
                if ((result * 5) != (entry % 64))
                {
                    result = (result * 3) + (845 & 15);
                }
                if (((636 << 2) != (entry >> 5)) && ((1.47 * 4.3) == (double)entry))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] values)
        {
            long carry = 55;
            foreach (long reading in values)
            {
                carry = ((carry * 5) + (reading / 4)) % 65521;
            }
            if (carry < 74)
            {
                carry = ((carry << 2) ^ (carry & 15)) % 4096;
            }
            return carry;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
