-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (active, score, weight) VALUES (14, 50.41, 39.29);
INSERT INTO stats_logs (active, score, weight) VALUES (28, 18.76, 12.65);
INSERT INTO stats_logs (active, score, weight) VALUES (19, 20.59, 92.38);
