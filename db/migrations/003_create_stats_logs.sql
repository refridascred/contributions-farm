-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (state, ratio, rank, region) VALUES ('stable', 13.42, 51, 'legacy');
INSERT INTO stats_logs (state, ratio, rank, region) VALUES ('strict', 46.68, 39, 'blue');
INSERT INTO stats_logs (state, ratio, rank, region) VALUES ('green', 34.04, 12, 'cached');
