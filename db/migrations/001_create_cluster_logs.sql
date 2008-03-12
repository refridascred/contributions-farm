-- Create the cluster_logs table.
CREATE TABLE IF NOT EXISTS cluster_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_cluster_logs_count ON cluster_logs (count);

INSERT INTO cluster_logs (rank, region, active, count) VALUES (33, 'legacy', 94, 44);
INSERT INTO cluster_logs (rank, region, active, count) VALUES (0, 'stable', 2, 80);
INSERT INTO cluster_logs (rank, region, active, count) VALUES (65, 'latest', 9, 19);
