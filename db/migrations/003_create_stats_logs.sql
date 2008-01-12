-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (ratio, rank, count) VALUES (33.61, 93, 29);
INSERT INTO stats_logs (ratio, rank, count) VALUES (34.15, 77, 87);
INSERT INTO stats_logs (ratio, rank, count) VALUES (45.71, 17, 67);
