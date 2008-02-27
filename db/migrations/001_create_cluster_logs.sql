-- Create the cluster_logs table.
CREATE TABLE IF NOT EXISTS cluster_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_cluster_logs_score ON cluster_logs (score);

INSERT INTO cluster_logs (label, score, rank) VALUES ('strict', 48.01, 75);
