-- Create the cluster_logs table.
CREATE TABLE IF NOT EXISTS cluster_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_cluster_logs_ratio ON cluster_logs (ratio);

INSERT INTO cluster_logs (region, token, ratio, count, label) VALUES ('open', 'fallback', 3.97, 59, 'fallback');
