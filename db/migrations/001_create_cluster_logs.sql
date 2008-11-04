-- Create the cluster_logs table.
CREATE TABLE IF NOT EXISTS cluster_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_cluster_logs_token ON cluster_logs (token);

INSERT INTO cluster_logs (token, state, ratio) VALUES ('edge', 'stable', 37.89);
INSERT INTO cluster_logs (token, state, ratio) VALUES ('edge', 'edge', 78.75);
INSERT INTO cluster_logs (token, state, ratio) VALUES ('green', 'blue', 47.66);
