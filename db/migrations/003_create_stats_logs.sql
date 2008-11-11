-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (count, weight, region, active, level) VALUES (57, 86.19, 'primary', 85, 13);
INSERT INTO stats_logs (count, weight, region, active, level) VALUES (60, 7.26, 'cached', 38, 49);
