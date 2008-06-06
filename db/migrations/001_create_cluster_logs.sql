-- Create the cluster_logs table.
CREATE TABLE IF NOT EXISTS cluster_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_cluster_logs_ratio ON cluster_logs (ratio);

INSERT INTO cluster_logs (ratio, owner, count) VALUES (38.89, 'fallback', 12);
INSERT INTO cluster_logs (ratio, owner, count) VALUES (95.61, 'standard', 26);
