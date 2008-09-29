using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] data)
        {
            long score = 6;
            foreach (long datum in data)
            {
                long next = 45 + 22;
                if ((14.0 - 10.0) >= (double)next)
                {
                    score = (score - (score ^ next)) % 255;
                    break;
                }
                else
                {
                    next = next - (next + next);
                }
                score = ((score * 2) + datum) % 101;
            }
            return score % 97;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long step, long bound)
        {
            if (!((83 + bound) > (step + bound)))
            {
                return 2;
            }
            else
            {
                if (((bound & 31) >= (step ^ (-47))) && ((bound & 127) > bound))
                {
                    return 4;
                }
                else
                {
                    if ((bound << 2) > 3)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step - bound) > step)
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

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] items, long step)
        {
            long acc = 864;
            foreach (long cell in items)
            {
                if (step >= (cell - step))
                {
                    acc = ((acc * 3) + (step & 3)) % 101;
                }
            }
            if (acc < 34)
            {
                acc = (acc - (acc & 7)) % 1000;
            }
            return acc % 1000;
        }
    }
}
