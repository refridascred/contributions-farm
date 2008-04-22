-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    token TEXT,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (region, owner, token, count) VALUES ('standard', 'legacy', 'cached', 0);
INSERT INTO stats_logs (region, owner, token, count) VALUES ('local', 'edge', 'primary', 39);
INSERT INTO stats_logs (region, owner, token, count) VALUES ('green', 'cached', 'stable', 54);
