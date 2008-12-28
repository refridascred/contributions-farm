-- Create the cluster_logs table.
CREATE TABLE IF NOT EXISTS cluster_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_cluster_logs_region ON cluster_logs (region);

INSERT INTO cluster_logs (region, owner, state, rank) VALUES ('blue', 'strict', 'fallback', 20);
