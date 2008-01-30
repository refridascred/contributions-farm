-- Create the cluster_logs table.
CREATE TABLE IF NOT EXISTS cluster_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_cluster_logs_rank ON cluster_logs (rank);
