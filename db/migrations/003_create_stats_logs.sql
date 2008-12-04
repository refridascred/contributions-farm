-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (ratio, count, weight) VALUES (60.0, 96, 85.2);
INSERT INTO stats_logs (ratio, count, weight) VALUES (69.33, 54, 26.01);
INSERT INTO stats_logs (ratio, count, weight) VALUES (38.25, 62, 57.76);
