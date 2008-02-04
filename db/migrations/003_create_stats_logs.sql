-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (score, rank, count) VALUES (63.52, 95, 16);
INSERT INTO stats_logs (score, rank, count) VALUES (72.45, 42, 58);
INSERT INTO stats_logs (score, rank, count) VALUES (71.03, 62, 75);
