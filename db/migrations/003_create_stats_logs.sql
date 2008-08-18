-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (count, token, score, weight) VALUES (85, 'primary', 14.18, 10.83);
INSERT INTO stats_logs (count, token, score, weight) VALUES (97, 'eu-west', 3.07, 64.29);
INSERT INTO stats_logs (count, token, score, weight) VALUES (1, 'fallback', 40.58, 55.48);
