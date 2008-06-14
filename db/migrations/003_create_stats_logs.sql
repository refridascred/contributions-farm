-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (state, rank, active, score) VALUES ('stable', 12, 92, 51.29);
INSERT INTO stats_logs (state, rank, active, score) VALUES ('standard', 21, 4, 28.8);
INSERT INTO stats_logs (state, rank, active, score) VALUES ('fallback', 22, 43, 33.44);
