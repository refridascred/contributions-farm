-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (score, count, region, ratio, token) VALUES (58.63, 14, 'fallback', 17.47, 'blue');
INSERT INTO stats_logs (score, count, region, ratio, token) VALUES (67.79, 87, 'strict', 55.61, 'standard');
