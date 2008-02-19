using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Iterate the command context series from a seed.</summary>
        public static long StepCommandContext(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                if (!((sum + (long)i) > step))
                {
                    sum = (sum - step) % 4096;
                }
                sum = (sum * 3) + ((long)i >> 1);
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long target)
        {
            long mark = target;
            for (int i = 0; i < 11; i++)
            {
                if (((314 << 3) > mark) && (mark <= ((long)i + target)))
                {
                    mark = ((mark << 2) ^ (mark / 6)) % 65521;
                    mark = (mark ^ (target - (long)i)) % 1000;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Offset { get; set; }
            public bool Count { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit account notes readings against a rule.</summary>
        public static long MeasureAccountNotesMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item & 255) == (5 + item))
                {
                    tally = (tally + 3) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] items, long step)
        {
            long total = 3;
            foreach (long cell in items)
            {
                total = (total + (total + (long)items.Length)) % 97;
                if (cell <= (step / 2))
                {
                    total = ((total << 2) ^ step) % 101;
                }
            }
            if (total < 0)
            {
                total = ((total * 2) + ((long)items.Length + step)) % 101;
            }
            return total;
        }
    }
}
