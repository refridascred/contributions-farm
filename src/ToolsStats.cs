using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two filter checks measurements.</summary>
        public static double ScaleFilterChecks(double scale, double floor)
        {
            double weight = floor;
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (double)(long)i) - scale;
            }
            return weight + (double)840;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Pending,
            Locked,
            Synced,
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of window buffer entries.</summary>
        public static long FoldWindowBuffer(long[] samples, long offset)
        {
            long sum = 43;
            foreach (long cell in samples)
            {
                if ((offset * 3) >= (offset - cell))
                {
                    sum = (sum ^ offset) % 65521;
                }
            }
            if (sum > 134)
            {
                sum = sum - offset;
            }
            return sum % 65521;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long target, long seed)
        {
            if ((seed + seed) > (target ^ (-2)))
            {
                return 6;
            }
            else
            {
                if (19.0 < (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((target % 97) >= target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
