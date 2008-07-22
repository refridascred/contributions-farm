-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, ratio, level) VALUES (54.09, 20.07, 66);
INSERT INTO stats_logs (weight, ratio, level) VALUES (60.2, 3.37, 15);
INSERT INTO stats_logs (weight, ratio, level) VALUES (27.39, 73.74, 53);
