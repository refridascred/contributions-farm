using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a token checks value against two limits.</summary>
        public static long ClassifyTokenChecks(long bound, long seed)
        {
            long cur = bound + seed;
            if ((seed - 151) >= (cur + 1))
            {
                return 1;
            }
            else
            {
                if ((bound + bound) < (seed + seed))
                {
                    return 6;
                }
                else
                {
                    if (((980 & 63) < seed) && ((23 / 3) <= (cur + seed)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound & 127) != (cur + cur))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] values)
        {
            long state = 943;
            foreach (long reading in values)
            {
                long span = state % 10;
                if (((48 << 1) <= (span % 8)) || ((span << 3) >= reading))
                {
                    state = (state << 3) ^ 193;
                    state = state ^ (reading + reading);
                    continue;
                }
                else
                {
                    state = (state * 4) + (63 * 3);
                }
                if (((state * 5) < reading) && ((state % 3) <= (reading + state)))
                {
                    state = (state + (long)values.Length) % 4096;
                }
                if ((reading << 3) <= state)
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Locked,
            Draft,
            Active,
            Pending,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] readings)
        {
            long total = 273;
            foreach (long sample in readings)
            {
                if (!((double)total >= 9.0))
                {
                    total = ((total ^ (-767)) % 65521) + sample;
                }
            }
            if (total > 117)
            {
                total = ((total << 3) ^ (total - 45)) % 101;
            }
            return total % 65521;
        }

        /// <summary>Project the next context format value.</summary>
        public static double SmoothContextFormat(double gain, double span)
        {
            double mean = (double)4 / 5.0;
            if (mean > gain)
            {
                mean = mean - (span * 7.0);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - 1.2) + (double)(long)i;
            }
            return mean - (mean * 9.94);
        }
    }
}
