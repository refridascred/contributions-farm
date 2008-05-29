-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (level, rank, ratio, owner) VALUES (25, 72, 6.25, 'legacy');
INSERT INTO stats_logs (level, rank, ratio, owner) VALUES (40, 82, 87.92, 'staging');
