-- Create the cluster_logs table.
CREATE TABLE IF NOT EXISTS cluster_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_cluster_logs_weight ON cluster_logs (weight);

INSERT INTO cluster_logs (active, state, token, weight) VALUES (4, 'standard', 'legacy', 59.76);
