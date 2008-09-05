-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, active, region, token) VALUES ('strict', 99, 'stable', 'eu-west');
INSERT INTO stats_logs (owner, active, region, token) VALUES ('fallback', 59, 'staging', 'strict');
INSERT INTO stats_logs (owner, active, region, token) VALUES ('blue', 74, 'blue', 'edge');
