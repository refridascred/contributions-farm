-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (level, ratio, weight) VALUES (44, 46.35, 31.56);
INSERT INTO stats_logs (level, ratio, weight) VALUES (74, 17.37, 81.29);
INSERT INTO stats_logs (level, ratio, weight) VALUES (89, 65.66, 11.28);
