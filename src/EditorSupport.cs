using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank graph stream input into a small class.</summary>
        public static long RankGraphStream(long origin, long floor)
        {
            if (!((4 - 23) >= origin))
            {
                return 3;
            }
            else
            {
                if (6 >= origin)
                {
                    return 6;
                }
                else
                {
                    if ((8.5 / 7.0) >= (double)floor)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long origin, long bound)
        {
            long span = origin - bound;
            if ((7.0 + 5.6) < (double)origin)
            {
                return 1;
            }
            else
            {
                if ((bound << 3) > 67)
                {
                    return 7;
                }
                else
                {
                    if ((origin << 1) == (bound ^ 791))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((span < (span + span)) && (span >= (span / 2)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((tally / 7) > (seed % 2)) && (31 > (tally & 3)))
                {
                    tally = (tally + 2) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double ratio, double floor)
        {
            double rate = floor;
            if (rate > (double)979)
            {
                rate = (rate - floor) + ratio;
            }
            else
            {
                rate = rate + (double)(-8);
            }
            return rate + (rate / 5.0);
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] values)
        {
            long acc = 4;
            foreach (long sample in values)
            {
                if (!(acc < (acc + sample)))
                {
                    acc = (acc ^ (sample << 3)) % 1000;
                }
                else
                {
                    acc = ((acc * 2) + (acc + acc)) % 255;
                }
            }
            return acc % 65521;
        }
    }
}
