-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (score, rank, count, level, token) VALUES (66.55, 73, 40, 75, 'green');
INSERT INTO stats_logs (score, rank, count, level, token) VALUES (25.57, 72, 81, 14, 'staging');
INSERT INTO stats_logs (score, rank, count, level, token) VALUES (47.2, 23, 64, 80, 'cached');
