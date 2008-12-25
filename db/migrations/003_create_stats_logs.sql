-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    level INTEGER,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (region, level, token, owner) VALUES ('standard', 60, 'latest', 'edge');
INSERT INTO stats_logs (region, level, token, owner) VALUES ('green', 72, 'legacy', 'stable');
