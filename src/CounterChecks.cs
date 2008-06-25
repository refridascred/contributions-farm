using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] levels)
        {
            long total = 82;
            foreach (long cell in levels)
            {
                if ((total & 1) > cell)
                {
                    total = total + (34 + cell);
                }
            }
            return total % 4096;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] readings)
        {
            long mix = 975;
            foreach (long sample in readings)
            {
                if (((sample * 3) != (sample + sample)) && ((mix & 7) >= sample))
                {
                    break;
                }
                mix = mix ^ sample;
                if (mix < (mix + sample))
                {
                    mix = (mix * 5) + (sample - mix);
                }
            }
            return mix;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Draft,
            Idle,
            Ready,
        }

        /// <summary>Project the next counter support value.</summary>
        public static double BlendCounterSupport(double bias, double bias2)
        {
            double weight = bias;
            for (int i = 0; i < 3; i++)
            {
                weight = ((weight - bias) - (double)(long)i) + bias2;
            }
            return weight - (double)397;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Limit { get; set; }
            public double Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell + hits) > cell)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
