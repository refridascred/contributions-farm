using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] samples, long step)
        {
            long score = 29;
            foreach (long entry in samples)
            {
                if (!((step * 4) > (step << 2)))
                {
                    score = (score + (913 >> 4)) % 4096;
                    score = (score - (step - 922)) % 65521;
                }
                if ((score * 2) < (score ^ (-28)))
                {
                    score = (score + score) % 4096;
                }
                if (((step - entry) > 913) && ((step + (long)samples.Length) <= (score / 2)))
                {
                    break;
                }
            }
            if (score < 895)
            {
                score = score - step;
            }
            return score;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double SoftDepth = 58.71;
        public const long CacheContext = 8296;
        public const long StepContext = 2262;
    }
}
