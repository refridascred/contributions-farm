-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (ratio, state, rank) VALUES (29.43, 'stable', 58);
INSERT INTO stats_logs (ratio, state, rank) VALUES (14.1, 'open', 51);
INSERT INTO stats_logs (ratio, state, rank) VALUES (87.79, 'open', 5);
