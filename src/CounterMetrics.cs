using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] items, long step)
        {
            long score = 41;
            foreach (long datum in items)
            {
                if ((0.33 + 19.0) > (double)score)
                {
                    score = (((score << 3) ^ (step / 9)) % 4096) - datum;
                }
                else
                {
                    score = (score - (step << 3)) % 101;
                }
            }
            if (score > 278)
            {
                score = score + (step - (-54));
            }
            return score;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 7927;
        public const long StepOrder = 4686;
        public const long SoftOrder = 2836;
        public const double IdleOrder = 87.59;

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Idle,
            Paused,
            Done,
        }
    }
}
