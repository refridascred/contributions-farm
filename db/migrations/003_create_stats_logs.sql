-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (count, ratio, region, level) VALUES (63, 76.14, 'cached', 2);
INSERT INTO stats_logs (count, ratio, region, level) VALUES (84, 17.81, 'green', 3);
