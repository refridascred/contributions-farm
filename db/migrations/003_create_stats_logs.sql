-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    level INTEGER,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (rank, region, level, token, active) VALUES (99, 'stable', 54, 'blue', 57);
INSERT INTO stats_logs (rank, region, level, token, active) VALUES (39, 'open', 82, 'local', 33);
