-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (score, ratio, token) VALUES (11.38, 41.37, 'latest');
INSERT INTO stats_logs (score, ratio, token) VALUES (42.8, 38.2, 'staging');
INSERT INTO stats_logs (score, ratio, token) VALUES (36.32, 17.97, 'eu-west');
