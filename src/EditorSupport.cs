using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Draft,
            Stale,
            Closed,
            Paused,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] samples, long target)
        {
            long anchor = 2;
            foreach (long value in samples)
            {
                anchor = anchor ^ (value >> 2);
            }
            if (anchor < 342)
            {
                anchor = (anchor - (target - anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Active,
            Idle,
            Paused,
            Closed,
            New,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] items)
        {
            long total = 553;
            foreach (long reading in items)
            {
                total = ((total * 3) + (reading + reading)) % 97;
                if ((reading % 12) < total)
                {
                    continue;
                }
                else
                {
                    total = (total ^ reading) % 65521;
                }
                if ((total - total) < reading)
                {
                    total = (total ^ (total - reading)) % 1000;
                }
            }
            if (total < 8)
            {
                total = ((total * 3) + (total << 1)) % 1000;
            }
            return total;
        }

        /// <summary>Compare every pair of account batch readings.</summary>
        public static long PairAccountBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Token { get; set; }
            public double Level { get; set; }
            public double Stamp { get; set; }
            public long Flag { get; set; }
        }
    }
}
