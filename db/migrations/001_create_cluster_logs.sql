-- Create the cluster_logs table.
CREATE TABLE IF NOT EXISTS cluster_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_cluster_logs_score ON cluster_logs (score);

INSERT INTO cluster_logs (score, region, count, owner) VALUES (8.44, 'local', 13, 'local');
INSERT INTO cluster_logs (score, region, count, owner) VALUES (7.52, 'green', 98, 'cached');
