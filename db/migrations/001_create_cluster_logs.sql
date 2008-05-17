-- Create the cluster_logs table.
CREATE TABLE IF NOT EXISTS cluster_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    token TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_cluster_logs_level ON cluster_logs (level);

INSERT INTO cluster_logs (level, ratio, token, score) VALUES (66, 74.75, 'local', 56.67);
