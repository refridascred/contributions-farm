-- Create the cluster_logs table.
CREATE TABLE IF NOT EXISTS cluster_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_cluster_logs_label ON cluster_logs (label);

INSERT INTO cluster_logs (rank, label, state, count) VALUES (20, 'local', 'stable', 69);
