-- Create the cluster_logs table.
CREATE TABLE IF NOT EXISTS cluster_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_cluster_logs_label ON cluster_logs (label);

INSERT INTO cluster_logs (level, state, label) VALUES (39, 'primary', 'local');
