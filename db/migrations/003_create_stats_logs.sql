-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (rank, score, state, ratio) VALUES (92, 3.88, 'local', 87.37);
INSERT INTO stats_logs (rank, score, state, ratio) VALUES (38, 76.39, 'green', 80.0);
INSERT INTO stats_logs (rank, score, state, ratio) VALUES (42, 28.77, 'staging', 92.97);
