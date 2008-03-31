-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    weight REAL,
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (token, ratio, weight, level) VALUES ('green', 7.42, 4.24, 75);
INSERT INTO stats_logs (token, ratio, weight, level) VALUES ('primary', 64.87, 94.59, 19);
