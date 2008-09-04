-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, label, score) VALUES (0.04, 'green', 59.25);
INSERT INTO stats_logs (weight, label, score) VALUES (49.96, 'latest', 48.97);
INSERT INTO stats_logs (weight, label, score) VALUES (47.9, 'blue', 75.04);
