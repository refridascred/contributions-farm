-- Create the cluster_logs table.
CREATE TABLE IF NOT EXISTS cluster_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_cluster_logs_score ON cluster_logs (score);

INSERT INTO cluster_logs (score, owner, level) VALUES (40.68, 'local', 79);
INSERT INTO cluster_logs (score, owner, level) VALUES (54.89, 'open', 4);
