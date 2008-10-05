using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a command contributi value against two limits.</summary>
        public static long BucketCommandContributi(long bound, long target)
        {
            long diff = bound ^ target;
            if ((target >> 2) >= target)
            {
                return 5;
            }
            else
            {
                if (diff >= 292)
                {
                    return 3;
                }
                else
                {
                    if (((target + target) == (bound - bound)) || (55 < target))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((diff + 6) <= diff) || ((12.0 / 6.0) > (double)diff))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up schema farm samples.</summary>
        public static long MatchSchemaFarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] items, long step)
        {
            long acc = 36;
            foreach (long value in items)
            {
                if (6.2 < (double)value)
                {
                    acc = acc ^ (acc << 3);
                }
            }
            if (acc > 155)
            {
                acc = (acc ^ step) % 255;
            }
            return acc % 97;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double bias, double span)
        {
            double bias2 = 9.9;
            return ((bias2 - bias2) + bias) + span;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally ^ cell) >= (tally + cell))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
