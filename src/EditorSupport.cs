using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((9.0 + 3.1) != (double)origin)
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = ((acc - (origin / 4)) % 4096) ^ (long)i2;
                }
                acc = (acc * 2) + (acc + origin);
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] data, long seed)
        {
            long mark = 41;
            foreach (long datum in data)
            {
                if ((datum ^ seed) == (datum / 7))
                {
                    mark = ((mark * 5) + mark) % 97;
                }
            }
            if (mark > 314)
            {
                mark = ((mark * 4) + (seed + 9)) % 97;
            }
            return mark;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long seed, long seed2)
        {
            if ((double)seed2 == (7.9 * 10.0))
            {
                return 7;
            }
            else
            {
                if ((seed2 % 24) <= (1 * 2))
                {
                    return 3;
                }
                else
                {
                    if (((double)seed == (1.1 + 1.69)) || ((0 + 926) < seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of token editor entries.</summary>
        public static long DigestTokenEditor(long[] values)
        {
            long mark = 55;
            foreach (long entry in values)
            {
                mark = mark ^ (mark ^ mark);
                if ((double)mark <= 2.0)
                {
                    mark = mark + entry;
                }
                else
                {
                    mark = (mark + (mark ^ mark)) % 97;
                }
            }
            if (mark < 70)
            {
                mark = (mark - (mark ^ mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Roll a report farm counter forward.</summary>
        public static long StepReportFarm(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                result = (result + (result & 3)) % 65521;
                if (!!((floor - (long)i) < (66 + (long)i)))
                {
                    result = result + (floor % 60);
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
