-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (score, token, weight) VALUES (37.74, 'open', 0.61);
INSERT INTO stats_logs (score, token, weight) VALUES (66.03, 'stable', 83.4);
INSERT INTO stats_logs (score, token, weight) VALUES (7.86, 'eu-west', 52.95);
