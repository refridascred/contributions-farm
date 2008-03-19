-- Create the cluster_logs table.
CREATE TABLE IF NOT EXISTS cluster_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_cluster_logs_ratio ON cluster_logs (ratio);

INSERT INTO cluster_logs (ratio, weight, owner, active, label) VALUES (30.54, 24.35, 'edge', 7, 'eu-west');
INSERT INTO cluster_logs (ratio, weight, owner, active, label) VALUES (91.01, 9.27, 'legacy', 14, 'green');
INSERT INTO cluster_logs (ratio, weight, owner, active, label) VALUES (35.8, 43.03, 'green', 46, 'staging');
