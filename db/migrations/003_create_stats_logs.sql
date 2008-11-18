-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (count, owner, region, token) VALUES (35, 'cached', 'green', 'fallback');
INSERT INTO stats_logs (count, owner, region, token) VALUES (5, 'stable', 'open', 'blue');
INSERT INTO stats_logs (count, owner, region, token) VALUES (95, 'legacy', 'standard', 'edge');
