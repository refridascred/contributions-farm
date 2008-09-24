-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (level, count, rank) VALUES (60, 32, 47);
INSERT INTO stats_logs (level, count, rank) VALUES (4, 16, 71);
INSERT INTO stats_logs (level, count, rank) VALUES (99, 0, 41);
