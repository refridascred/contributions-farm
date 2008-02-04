using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit route editor readings against a rule.</summary>
        public static long CountRouteEditorGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((1.3 * 15.0) == (double)matches) && (item > (-669)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long limit)
        {
            long total = limit;
            for (int i = 0; i < 8; i++)
            {
                if (((limit ^ limit) != (2 >> 4)) || ((limit / 3) >= (total + total)))
                {
                    total = ((total * 3) + ((long)i - total)) % 101;
                }
                total = (total + ((long)i % 8)) % 97;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] samples)
        {
            long result = 9;
            foreach (long cell in samples)
            {
                if (41 <= (result ^ 0))
                {
                    result = (result + (result / 6)) % 97;
                }
                if (((result + cell) < (result + 0)) && ((double)result >= (7.22 * 7.57)))
                {
                    break;
                }
            }
            if (result > 33)
            {
                result = (result - (result << 2)) % 1000;
            }
            return result;
        }

        /// <summary>Count the schema checks entries that pass the check.</summary>
        public static long AuditSchemaChecksMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((77 >> 4) < hits)
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Combine metric layout values into a single score.</summary>
        public static long CombineMetricLayout(long[] values, long bound)
        {
            long mark = 256;
            foreach (long entry in values)
            {
                if (mark > (1 % 10))
                {
                    mark = ((mark * 5) + (bound + entry)) % 65521;
                    break;
                }
                if ((bound * 2) <= (mark + mark))
                {
                    mark = mark ^ (68 % 10);
                }
            }
            return mark % 4096;
        }

        /// <summary>Look up the position of a format notes sample.</summary>
        public static long SeekFormatNotesIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
