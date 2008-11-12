using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Score { get; set; }
            public bool Stamp { get; set; }
            public long Weight { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Audit buffer context readings against a rule.</summary>
        public static long AuditBufferContextHits(long[] series, long step)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!((entry & 31) > ((long)series.Length / 9)) && ((tally + tally) <= (entry - step)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] samples, long step)
        {
            long result = 916;
            foreach (long sample in samples)
            {
                result = (result + step) % 65521;
                if ((step + step) == (step + sample))
                {
                    result = (result ^ (result << 3)) % 65521;
                }
                else
                {
                    result = ((result << 3) ^ (step + sample)) % 1000;
                }
            }
            if (result > 3)
            {
                result = (result + (result & 3)) % 255;
            }
            return result;
        }
    }
}
