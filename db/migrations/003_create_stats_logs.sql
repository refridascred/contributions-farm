-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (rank, weight, token, state, level) VALUES (17, 47.39, 'legacy', 'green', 34);
INSERT INTO stats_logs (rank, weight, token, state, level) VALUES (13, 80.04, 'stable', 'staging', 34);
