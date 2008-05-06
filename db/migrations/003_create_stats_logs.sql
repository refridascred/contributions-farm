-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (ratio, active, level, region, weight) VALUES (11.48, 97, 86, 'eu-west', 0.05);
INSERT INTO stats_logs (ratio, active, level, region, weight) VALUES (84.8, 4, 8, 'standard', 94.62);
