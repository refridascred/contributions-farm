-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (label, count, rank, ratio, owner) VALUES ('staging', 52, 77, 93.97, 'fallback');
INSERT INTO stats_logs (label, count, rank, ratio, owner) VALUES ('latest', 77, 26, 87.52, 'fallback');
INSERT INTO stats_logs (label, count, rank, ratio, owner) VALUES ('blue', 18, 10, 12.02, 'staging');
