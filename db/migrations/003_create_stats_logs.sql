-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (ratio, owner, rank) VALUES (38.4, 'blue', 52);
INSERT INTO stats_logs (ratio, owner, rank) VALUES (22.33, 'blue', 10);
INSERT INTO stats_logs (ratio, owner, rank) VALUES (96.34, 'fallback', 78);
