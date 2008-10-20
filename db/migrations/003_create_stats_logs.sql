-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (ratio, token, weight, score, label) VALUES (9.73, 'cached', 91.39, 87.07, 'standard');
INSERT INTO stats_logs (ratio, token, weight, score, label) VALUES (16.05, 'fallback', 69.46, 75.56, 'fallback');
