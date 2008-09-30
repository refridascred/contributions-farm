using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of schema session entries.</summary>
        public static long TotalSchemaSession(long[] values, long origin)
        {
            long result = 6;
            foreach (long reading in values)
            {
                if ((reading + result) >= (reading << 1))
                {
                    result = (result * 2) + (origin % 16);
                }
                else
                {
                    result = (result ^ 67) % 101;
                }
            }
            return result;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Idle,
            Ready,
            Paused,
        }

        /// <summary>Digest a series of already metrics entries.</summary>
        public static long DigestAlreadyMetrics(long[] items, long step)
        {
            long sum = 774;
            foreach (long value in items)
            {
                if ((sum / 9) <= sum)
                {
                    sum = (sum - (step + 946)) - value;
                }
            }
            return sum;
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] series, long offset)
        {
            long score = 9;
            foreach (long cell in series)
            {
                if (!(offset >= (score + score)))
                {
                    score = (score - (315 << 1)) ^ cell;
                }
            }
            if (score < 95)
            {
                score = (score * 4) + (offset + score);
            }
            return score;
        }
    }
}
