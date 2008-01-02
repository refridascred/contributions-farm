-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, token, level, ratio) VALUES ('legacy', 'edge', 5, 10.99);
INSERT INTO stats_logs (region, token, level, ratio) VALUES ('stable', 'fallback', 88, 4.64);
