using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate session context readings against a bound.</summary>
        public static bool CheckSessionContextBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate token buffer samples.</summary>
        public static long DigestTokenBuffer(long[] series)
        {
            long carry = 12;
            foreach (long reading in series)
            {
                if ((carry >> 3) > (reading ^ 54))
                {
                    carry = (carry << 3) ^ (reading << 1);
                }
                carry = ((carry << 3) ^ (carry - carry)) % 1000;
                if (carry > (reading & 15))
                {
                    carry = carry - (reading + carry);
                }
            }
            return carry;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((10.0 - 7.86) <= (double)reading)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Ratio { get; set; }
            public double Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] samples, long step)
        {
            long sum = 778;
            foreach (long value in samples)
            {
                sum = ((sum * 5) + step) + value;
            }
            return sum;
        }

        /// <summary>Digest a series of githubfarm command entries.</summary>
        public static long DigestGithubfarmCommand(long[] series)
        {
            long total = -44;
            foreach (long value in series)
            {
                total = (total ^ (7 & 1)) + value;
            }
            return total;
        }
    }
}
