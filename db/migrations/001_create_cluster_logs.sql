-- Create the cluster_logs table.
CREATE TABLE IF NOT EXISTS cluster_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_cluster_logs_level ON cluster_logs (level);

INSERT INTO cluster_logs (level, active, score, region) VALUES (98, 35, 50.12, 'staging');
INSERT INTO cluster_logs (level, active, score, region) VALUES (58, 25, 3.97, 'eu-west');
