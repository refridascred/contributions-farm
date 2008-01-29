-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (level, owner, region, token) VALUES (11, 'local', 'legacy', 'strict');
INSERT INTO stats_logs (level, owner, region, token) VALUES (79, 'stable', 'edge', 'eu-west');
