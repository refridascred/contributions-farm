-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (level, count, ratio, region) VALUES (3, 50, 52.26, 'stable');
INSERT INTO stats_logs (level, count, ratio, region) VALUES (45, 91, 30.45, 'open');
