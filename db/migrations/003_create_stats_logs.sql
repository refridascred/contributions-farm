-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (count, weight, region, level) VALUES (56, 50.46, 'fallback', 23);
INSERT INTO stats_logs (count, weight, region, level) VALUES (82, 86.35, 'local', 46);
