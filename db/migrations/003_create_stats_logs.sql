-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (ratio, weight, level) VALUES (24.02, 38.43, 58);
INSERT INTO stats_logs (ratio, weight, level) VALUES (14.96, 91.98, 20);
INSERT INTO stats_logs (ratio, weight, level) VALUES (11.49, 54.26, 66);
