-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (level, rank, weight, count, token) VALUES (10, 60, 74.15, 7, 'eu-west');
INSERT INTO stats_logs (level, rank, weight, count, token) VALUES (68, 34, 18.64, 99, 'standard');
