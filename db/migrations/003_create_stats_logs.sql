-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (level, ratio, weight, score, token) VALUES (64, 72.95, 15.06, 87.62, 'fallback');
INSERT INTO stats_logs (level, ratio, weight, score, token) VALUES (88, 16.3, 93.0, 84.75, 'staging');
INSERT INTO stats_logs (level, ratio, weight, score, token) VALUES (46, 62.29, 41.54, 83.59, 'fallback');
