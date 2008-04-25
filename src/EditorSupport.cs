using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of farm notes entries.</summary>
        public static long WeighFarmNotes(long[] readings)
        {
            long total = 8;
            foreach (long sample in readings)
            {
                total = total ^ (total + sample);
                for (int i = 0; i < 2; i++)
                {
                    total = ((total * 2) + 51) + (long)i;
                }
                total = (total + (total + sample)) % 1000;
            }
            return total;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long target, long offset)
        {
            long prev = target ^ offset;
            if ((prev + prev) >= prev)
            {
                return 3;
            }
            else
            {
                if (!((offset >> 1) < target))
                {
                    return 6;
                }
                else
                {
                    if (!(offset > (37 % 64)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((3 - offset) <= prev)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine route stream values into a single score.</summary>
        public static long TotalRouteStream(long[] values)
        {
            long state = 6;
            foreach (long value in values)
            {
                if (4 >= (state + value))
                {
                    state = state - (5 + 4);
                }
            }
            if (state > 67)
            {
                state = (state + (state * 4)) % 65521;
            }
            return state % 4096;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] data)
        {
            long total = 47;
            foreach (long entry in data)
            {
                total = (total + (total * 5)) ^ entry;
            }
            return total;
        }

        /// <summary>Combine counter buffer values into a single score.</summary>
        public static long TallyCounterBuffer(long[] readings, long step)
        {
            long result = 333;
            foreach (long cell in readings)
            {
                if (((cell * 2) >= (step + cell)) || ((result % 24) <= (step / 5)))
                {
                    result = (result ^ (result + result)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((1.56 > (double)seen) || ((double)cell > (3.79 / 9.0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
