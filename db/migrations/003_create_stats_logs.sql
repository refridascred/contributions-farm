-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    weight REAL,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (score, token, weight, ratio) VALUES (93.17, 'blue', 79.35, 14.63);
INSERT INTO stats_logs (score, token, weight, ratio) VALUES (54.42, 'stable', 66.9, 45.85);
INSERT INTO stats_logs (score, token, weight, ratio) VALUES (24.63, 'open', 28.36, 14.09);
