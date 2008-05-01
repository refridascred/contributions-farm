-- Create the cluster_logs table.
CREATE TABLE IF NOT EXISTS cluster_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_cluster_logs_score ON cluster_logs (score);

INSERT INTO cluster_logs (level, score, weight, label) VALUES (54, 36.59, 15.09, 'green');
INSERT INTO cluster_logs (level, score, weight, label) VALUES (16, 53.65, 36.02, 'cached');
INSERT INTO cluster_logs (level, score, weight, label) VALUES (85, 11.64, 30.35, 'strict');
