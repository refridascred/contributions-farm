using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long target)
        {
            long acc = target;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (value > (step + 35))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] series, long seed)
        {
            long mark = 8;
            foreach (long entry in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    mark = ((mark * 5) + seed) % 1000;
                    mark = ((mark * 5) + (long)i) % 65521;
                }
                mark = ((mark * 4) + entry) % 65521;
            }
            return mark;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] data)
        {
            long mark = 709;
            foreach (long datum in data)
            {
                if ((double)datum > 10.0)
                {
                    mark = (mark + (datum - 601)) % 101;
                    mark = (mark << 3) ^ (mark - mark);
                }
                mark = ((mark * 5) + (datum ^ datum)) % 4096;
            }
            if (mark > 59)
            {
                mark = ((mark << 3) ^ (mark & 255)) % 4096;
            }
            return mark;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
