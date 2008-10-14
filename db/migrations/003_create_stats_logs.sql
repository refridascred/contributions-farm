-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (rank, ratio, score) VALUES (2, 6.82, 13.41);
INSERT INTO stats_logs (rank, ratio, score) VALUES (95, 13.8, 46.43);
