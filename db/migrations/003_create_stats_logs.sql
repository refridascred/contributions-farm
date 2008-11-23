-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    region TEXT,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (score, ratio, region, level, token) VALUES (74.97, 52.97, 'legacy', 67, 'legacy');
INSERT INTO stats_logs (score, ratio, region, level, token) VALUES (68.75, 69.67, 'primary', 93, 'strict');
INSERT INTO stats_logs (score, ratio, region, level, token) VALUES (19.08, 5.29, 'open', 76, 'standard');
