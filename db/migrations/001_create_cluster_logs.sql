-- Create the cluster_logs table.
CREATE TABLE IF NOT EXISTS cluster_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_cluster_logs_created_at ON cluster_logs (created_at);

INSERT INTO cluster_logs (rank, owner, level) VALUES (75, 'green', 49);
INSERT INTO cluster_logs (rank, owner, level) VALUES (71, 'stable', 56);
INSERT INTO cluster_logs (rank, owner, level) VALUES (77, 'staging', 79);
