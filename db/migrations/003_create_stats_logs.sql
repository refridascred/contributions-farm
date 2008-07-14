-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, label, count, ratio) VALUES (95.25, 'stable', 57, 39.32);
INSERT INTO stats_logs (weight, label, count, ratio) VALUES (91.23, 'local', 70, 89.2);
INSERT INTO stats_logs (weight, label, count, ratio) VALUES (59.41, 'fallback', 67, 84.56);
