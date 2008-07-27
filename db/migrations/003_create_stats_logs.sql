-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (token, score, weight) VALUES ('fallback', 54.19, 38.03);
INSERT INTO stats_logs (token, score, weight) VALUES ('primary', 26.16, 89.26);
INSERT INTO stats_logs (token, score, weight) VALUES ('primary', 12.78, 29.47);
