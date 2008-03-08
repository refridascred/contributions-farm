-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (active, ratio, owner, rank) VALUES (43, 89.25, 'stable', 61);
INSERT INTO stats_logs (active, ratio, owner, rank) VALUES (95, 14.58, 'cached', 2);
INSERT INTO stats_logs (active, ratio, owner, rank) VALUES (13, 69.95, 'eu-west', 33);
