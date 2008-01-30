-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (rank, active, token, weight, count) VALUES (58, 20, 'standard', 73.3, 53);
INSERT INTO stats_logs (rank, active, token, weight, count) VALUES (98, 75, 'open', 92.88, 44);
INSERT INTO stats_logs (rank, active, token, weight, count) VALUES (8, 6, 'blue', 40.41, 54);
