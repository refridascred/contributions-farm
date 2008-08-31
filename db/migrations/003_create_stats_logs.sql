-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, count, level) VALUES (91.76, 94, 66);
INSERT INTO stats_logs (weight, count, level) VALUES (33.89, 8, 24);
INSERT INTO stats_logs (weight, count, level) VALUES (61.46, 56, 51);
