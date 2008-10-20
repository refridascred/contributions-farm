-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (active, weight, region, score, token) VALUES (33, 28.71, 'legacy', 46.99, 'staging');
INSERT INTO stats_logs (active, weight, region, score, token) VALUES (58, 98.6, 'staging', 2.06, 'legacy');
INSERT INTO stats_logs (active, weight, region, score, token) VALUES (84, 67.77, 'stable', 75.85, 'staging');
