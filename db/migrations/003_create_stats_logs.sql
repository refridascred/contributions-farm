-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (level, rank, token, weight) VALUES (79, 24, 'blue', 33.19);
INSERT INTO stats_logs (level, rank, token, weight) VALUES (62, 78, 'open', 16.74);
