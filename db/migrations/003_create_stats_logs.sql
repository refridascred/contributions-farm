-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (active, count, score, weight) VALUES (89, 47, 18.75, 94.09);
INSERT INTO stats_logs (active, count, score, weight) VALUES (23, 26, 28.96, 29.45);
INSERT INTO stats_logs (active, count, score, weight) VALUES (53, 61, 97.0, 6.81);
