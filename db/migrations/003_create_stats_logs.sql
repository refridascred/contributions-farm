-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (region, token, score, weight) VALUES ('fallback', 'green', 51.16, 75.95);
INSERT INTO stats_logs (region, token, score, weight) VALUES ('primary', 'primary', 66.46, 43.66);
