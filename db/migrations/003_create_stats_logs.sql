-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (active, level, score, rank) VALUES (10, 38, 67.77, 98);
INSERT INTO stats_logs (active, level, score, rank) VALUES (29, 5, 40.9, 74);
