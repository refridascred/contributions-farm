-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, token, active) VALUES (37.0, 'eu-west', 54);
INSERT INTO stats_logs (weight, token, active) VALUES (7.86, 'stable', 53);
INSERT INTO stats_logs (weight, token, active) VALUES (94.03, 'legacy', 51);
