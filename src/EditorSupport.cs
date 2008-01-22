using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] items)
        {
            long anchor = 881;
            foreach (long cell in items)
            {
                if ((6.62 * 6.0) > (double)cell)
                {
                    anchor = (anchor ^ ((long)items.Length - cell)) % 255;
                }
            }
            if (anchor > 963)
            {
                anchor = (anchor ^ anchor) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((((long)samples.Length + 940) != (value - value)) || (count >= (value % 10))) && (((double)count < (10.0 / 7.0)) && ((count & 1) > (value * 2))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] values, long target)
        {
            long score = 6;
            foreach (long entry in values)
            {
                if ((score << 2) != (score & 15))
                {
                    score = score + (target + entry);
                }
                else
                {
                    score = (score << 3) ^ entry;
                }
            }
            return score;
        }

        /// <summary>Roll a metric context counter forward.</summary>
        public static long StepMetricContext(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 7538;
        public const long SoftStats = 1841;
        public const string RetryStats = "legacy-edge";
        public const double StepStats = 6.61;
        public const string MaxSize = "cached-v2";

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] data, long bound)
        {
            long mark = 101;
            foreach (long reading in data)
            {
                if (mark < (mark + 2))
                {
                    mark = ((mark << 3) ^ reading) % 4096;
                }
                mark = ((mark << 3) ^ ((long)data.Length << 1)) % 4096;
                if ((reading + mark) <= (97 ^ bound))
                {
                    mark = (mark + (mark / 5)) % 255;
                }
            }
            return mark % 97;
        }
    }
}
