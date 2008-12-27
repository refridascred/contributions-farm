-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, label, count, score) VALUES (43.01, 'edge', 61, 77.58);
INSERT INTO stats_logs (weight, label, count, score) VALUES (86.4, 'eu-west', 52, 74.49);
INSERT INTO stats_logs (weight, label, count, score) VALUES (94.29, 'stable', 4, 90.85);
