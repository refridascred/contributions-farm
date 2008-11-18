-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    token TEXT,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, ratio, token, rank, count) VALUES ('edge', 87.51, 'stable', 23, 12);
INSERT INTO stats_logs (owner, ratio, token, rank, count) VALUES ('local', 83.09, 'cached', 53, 14);
