-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (ratio, label, level, weight) VALUES (13.36, 'primary', 27, 17.15);
INSERT INTO stats_logs (ratio, label, level, weight) VALUES (28.06, 'fallback', 21, 3.17);
