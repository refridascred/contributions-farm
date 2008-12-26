-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (label, active, count, owner, rank) VALUES ('staging', 66, 16, 'staging', 6);
INSERT INTO stats_logs (label, active, count, owner, rank) VALUES ('edge', 6, 6, 'staging', 80);
INSERT INTO stats_logs (label, active, count, owner, rank) VALUES ('fallback', 79, 25, 'staging', 42);
