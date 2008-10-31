-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (count, label, weight, level) VALUES (70, 'strict', 89.92, 8);
INSERT INTO stats_logs (count, label, weight, level) VALUES (23, 'standard', 5.64, 86);
INSERT INTO stats_logs (count, label, weight, level) VALUES (65, 'primary', 69.14, 89);
