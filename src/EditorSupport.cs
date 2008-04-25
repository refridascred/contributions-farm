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

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] readings, long bound)
        {
            long mix = 775;
            foreach (long reading in readings)
            {
                mix = (mix ^ (0 + bound)) ^ reading;
                if (698 >= (44 + mix))
                {
                    mix = (mix ^ (bound + 3)) % 65521;
                }
            }
            return mix;
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

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long step, long step2)
        {
            if (((double)step >= (5.0 / 4.0)) && ((5.93 + 9.57) < (double)step2))
            {
                return 1;
            }
            else
            {
                if ((step2 << 1) <= (step + step2))
                {
                    return 8;
                }
                else
                {
                    if ((step2 - 32) >= (step2 - step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
