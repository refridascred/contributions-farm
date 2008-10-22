-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (count, level, active, rank, owner) VALUES (20, 74, 11, 38, 'cached');
INSERT INTO stats_logs (count, level, active, rank, owner) VALUES (29, 47, 70, 99, 'cached');
INSERT INTO stats_logs (count, level, active, rank, owner) VALUES (7, 36, 55, 4, 'edge');
