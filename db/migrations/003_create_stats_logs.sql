-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (owner, region, count, token) VALUES ('staging', 'strict', 38, 'primary');
INSERT INTO stats_logs (owner, region, count, token) VALUES ('standard', 'edge', 78, 'edge');
INSERT INTO stats_logs (owner, region, count, token) VALUES ('cached', 'open', 74, 'open');
