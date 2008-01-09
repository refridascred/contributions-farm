-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (token, ratio, rank) VALUES ('latest', 19.69, 71);
INSERT INTO stats_logs (token, ratio, rank) VALUES ('primary', 72.31, 98);
