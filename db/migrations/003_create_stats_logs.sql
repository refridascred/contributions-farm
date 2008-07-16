-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (count, active, ratio, score, token) VALUES (87, 0, 10.38, 37.76, 'latest');
INSERT INTO stats_logs (count, active, ratio, score, token) VALUES (28, 79, 36.17, 21.82, 'cached');
INSERT INTO stats_logs (count, active, ratio, score, token) VALUES (81, 27, 43.24, 6.97, 'edge');
