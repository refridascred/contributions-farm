-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (score, region, level) VALUES (38.32, 'fallback', 61);
INSERT INTO stats_logs (score, region, level) VALUES (48.57, 'legacy', 30);
INSERT INTO stats_logs (score, region, level) VALUES (90.09, 'blue', 73);
