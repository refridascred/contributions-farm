-- Create the cluster_logs table.
CREATE TABLE IF NOT EXISTS cluster_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_cluster_logs_label ON cluster_logs (label);

INSERT INTO cluster_logs (label, region, level, count, token) VALUES ('open', 'local', 68, 22, 'blue');
