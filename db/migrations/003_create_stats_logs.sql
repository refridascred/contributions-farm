-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, score, token, weight) VALUES (97.4, 84.0, 'legacy', 16.68);
INSERT INTO stats_logs (ratio, score, token, weight) VALUES (11.8, 22.85, 'open', 71.41);
INSERT INTO stats_logs (ratio, score, token, weight) VALUES (64.98, 69.0, 'legacy', 47.91);
