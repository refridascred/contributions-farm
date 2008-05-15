-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (label, level, rank, state, region) VALUES ('stable', 3, 83, 'standard', 'cached');
INSERT INTO stats_logs (label, level, rank, state, region) VALUES ('staging', 79, 9, 'primary', 'latest');
INSERT INTO stats_logs (label, level, rank, state, region) VALUES ('edge', 80, 71, 'cached', 'latest');
