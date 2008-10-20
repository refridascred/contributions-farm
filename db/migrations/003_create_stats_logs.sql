-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (level, region, token) VALUES (88, 'edge', 'strict');
INSERT INTO stats_logs (level, region, token) VALUES (1, 'stable', 'fallback');
INSERT INTO stats_logs (level, region, token) VALUES (4, 'open', 'standard');
