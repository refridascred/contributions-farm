-- Create the cluster_logs table.
CREATE TABLE IF NOT EXISTS cluster_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_cluster_logs_region ON cluster_logs (region);

INSERT INTO cluster_logs (region, score, state) VALUES ('local', 42.49, 'stable');
INSERT INTO cluster_logs (region, score, state) VALUES ('green', 71.35, 'blue');
INSERT INTO cluster_logs (region, score, state) VALUES ('cached', 84.95, 'local');
