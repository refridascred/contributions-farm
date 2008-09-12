-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (ratio, count, owner, active, rank) VALUES (64.2, 14, 'open', 53, 44);
INSERT INTO stats_logs (ratio, count, owner, active, rank) VALUES (11.63, 56, 'edge', 75, 68);
