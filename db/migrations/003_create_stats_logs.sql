-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, level) VALUES (87.07, 97);
INSERT INTO stats_logs (weight, level) VALUES (49.24, 48);
INSERT INTO stats_logs (weight, level) VALUES (31.33, 27);
