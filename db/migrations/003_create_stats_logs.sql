-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (level, token, score, weight) VALUES (16, 'green', 23.76, 80.16);
INSERT INTO stats_logs (level, token, score, weight) VALUES (23, 'fallback', 18.77, 13.02);
