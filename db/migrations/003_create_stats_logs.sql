-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (weight, token, ratio, rank) VALUES (44.22, 'standard', 26.21, 27);
INSERT INTO stats_logs (weight, token, ratio, rank) VALUES (10.22, 'green', 23.1, 36);
