-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (active, weight, score) VALUES (79, 21.99, 38.81);
INSERT INTO stats_logs (active, weight, score) VALUES (95, 71.71, 95.79);
INSERT INTO stats_logs (active, weight, score) VALUES (98, 93.04, 70.86);
