-- Create the cluster_logs table.
CREATE TABLE IF NOT EXISTS cluster_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_cluster_logs_token ON cluster_logs (token);

INSERT INTO cluster_logs (state, active, owner, token, score) VALUES ('standard', 57, 'edge', 'strict', 16.7);
INSERT INTO cluster_logs (state, active, owner, token, score) VALUES ('green', 56, 'stable', 'latest', 39.35);
INSERT INTO cluster_logs (state, active, owner, token, score) VALUES ('blue', 92, 'staging', 'cached', 82.18);
