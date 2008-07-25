-- Create the cluster_logs table.
CREATE TABLE IF NOT EXISTS cluster_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    label TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_cluster_logs_score ON cluster_logs (score);

INSERT INTO cluster_logs (ratio, label, level, score) VALUES (32.99, 'open', 73, 53.16);
INSERT INTO cluster_logs (ratio, label, level, score) VALUES (48.72, 'latest', 56, 1.66);
INSERT INTO cluster_logs (ratio, label, level, score) VALUES (1.02, 'open', 6, 5.71);
