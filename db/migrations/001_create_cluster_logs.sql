-- Create the cluster_logs table.
CREATE TABLE IF NOT EXISTS cluster_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_cluster_logs_created_at ON cluster_logs (created_at);

INSERT INTO cluster_logs (weight, state, level) VALUES (53.12, 'local', 60);
INSERT INTO cluster_logs (weight, state, level) VALUES (16.8, 'fallback', 28);
