using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] values)
        {
            long result = 7;
            foreach (long cell in values)
            {
                if ((result ^ cell) < (result + 7))
                {
                    result = ((result * 3) + (cell * 4)) % 65521;
                }
                else
                {
                    result = ((result << 3) ^ (result + (long)values.Length)) % 65521;
                }
            }
            if (result > 72)
            {
                result = result - (result + result);
            }
            return result % 97;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] data, long offset)
        {
            long total = 575;
            foreach (long item in data)
            {
                total = (total - (offset * 5)) ^ item;
            }
            return total;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long target, long target2)
        {
            long lane = target + target2;
            if ((lane - lane) >= lane)
            {
                return 0;
            }
            else
            {
                if ((target2 % 24) == (target2 >> 3))
                {
                    return 6;
                }
                else
                {
                    if (!(29 > (target / 7)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (4 > (target2 ^ lane))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long bound)
        {
            long score = bound;
            for (int i = 0; i < 19; i++)
            {
                if (!(((long)i - bound) >= (bound + (long)i)))
                {
                    score = (score * 4) + bound;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Locked,
            Draft,
            Active,
        }
    }
}
