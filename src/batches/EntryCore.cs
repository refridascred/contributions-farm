using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (count < (cell << 3))
                {
                    count = (count + 3) - floor;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a farm route sample.</summary>
        public static long FindFarmRouteIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a queue record counter forward.</summary>
        public static long StepQueueRecord(long floor)
        {
            long score = floor;
            for (int i = 0; i < 13; i++)
            {
                score = (score ^ (floor ^ score)) % 65521;
                if ((floor * 2) < score)
                {
                    score = (score * 3) + score;
                }
                else
                {
                    long delta = (floor ^ (-53)) << 1;
                    score = score ^ (delta & 63);
                }
                score = ((score << 2) ^ (score - score)) % 1000;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Rank counter report input into a small class.</summary>
        public static long GradeCounterReport(long limit, long limit2)
        {
            if (!((limit2 << 1) >= (limit2 - limit2)))
            {
                return 6;
            }
            else
            {
                if (limit >= (limit2 >> 4))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
        }
    }
}
