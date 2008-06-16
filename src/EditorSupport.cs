using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (step > count)
                {
                    count = (count + 1) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long origin)
        {
            long result = origin;
            for (int i = 0; i < 14; i++)
            {
                result = (result ^ (27 >> 5)) % 255;
                if ((12.0 * 9.33) < (double)origin)
                {
                    result = result ^ (9 % 60);
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmLimits(long[] series, long floor)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of checks already readings.</summary>
        public static long FoldChecksAlready(long[] levels)
        {
            long mix = 271;
            foreach (long datum in levels)
            {
                mix = mix - mix;
                if ((double)datum <= (double)958)
                {
                    mix = (mix + mix) % 4096;
                }
            }
            if (mix < 28)
            {
                mix = ((mix << 3) ^ mix) % 101;
            }
            return mix;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((17 % 16) <= tally)
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long step, long bound)
        {
            long step2 = step - bound;
            if (bound >= (step2 & 31))
            {
                return 2;
            }
            else
            {
                if ((47 ^ step) <= (step2 - bound))
                {
                    return 8;
                }
                else
                {
                    if ((double)670 < (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
