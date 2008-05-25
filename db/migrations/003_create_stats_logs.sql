-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (token, owner, count) VALUES ('blue', 'local', 57);
INSERT INTO stats_logs (token, owner, count) VALUES ('green', 'standard', 30);
INSERT INTO stats_logs (token, owner, count) VALUES ('legacy', 'edge', 42);
