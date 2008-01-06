-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    created_at TIMESTAMP,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (weight, level, ratio, count) VALUES (32.15, 33, 61.6, 59);
INSERT INTO stats_logs (weight, level, ratio, count) VALUES (66.06, 41, 59.82, 80);
INSERT INTO stats_logs (weight, level, ratio, count) VALUES (46.92, 75, 92.09, 4);
