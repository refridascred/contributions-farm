-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (ratio, weight, region, count, level) VALUES (71.77, 80.65, 'cached', 58, 58);
INSERT INTO stats_logs (ratio, weight, region, count, level) VALUES (76.61, 97.33, 'eu-west', 21, 16);
INSERT INTO stats_logs (ratio, weight, region, count, level) VALUES (44.02, 63.89, 'staging', 3, 43);
