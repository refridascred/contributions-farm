-- Create the cluster_logs table.
CREATE TABLE IF NOT EXISTS cluster_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_cluster_logs_created_at ON cluster_logs (created_at);

INSERT INTO cluster_logs (owner, ratio, token) VALUES ('latest', 16.68, 'eu-west');
