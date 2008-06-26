-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (ratio, count, rank) VALUES (62.72, 74, 90);
INSERT INTO stats_logs (ratio, count, rank) VALUES (56.94, 36, 79);
INSERT INTO stats_logs (ratio, count, rank) VALUES (38.78, 65, 42);
