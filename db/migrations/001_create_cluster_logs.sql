-- Create the cluster_logs table.
CREATE TABLE IF NOT EXISTS cluster_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_cluster_logs_count ON cluster_logs (count);

INSERT INTO cluster_logs (weight, label, rank, active, count) VALUES (28.44, 'stable', 63, 34, 97);
