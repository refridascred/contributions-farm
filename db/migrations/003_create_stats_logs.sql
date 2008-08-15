-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (rank, level, count, owner, active) VALUES (20, 17, 82, 'legacy', 80);
INSERT INTO stats_logs (rank, level, count, owner, active) VALUES (38, 4, 89, 'latest', 12);
INSERT INTO stats_logs (rank, level, count, owner, active) VALUES (54, 71, 34, 'edge', 64);
