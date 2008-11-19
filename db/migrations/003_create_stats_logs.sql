-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    rank INTEGER,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, owner, rank, level, ratio) VALUES ('staging', 'standard', 55, 98, 8.32);
INSERT INTO stats_logs (token, owner, rank, level, ratio) VALUES ('latest', 'edge', 94, 57, 51.38);
