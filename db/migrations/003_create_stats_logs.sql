-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (weight, label, state, score, rank) VALUES (22.88, 'stable', 'cached', 58.19, 39);
INSERT INTO stats_logs (weight, label, state, score, rank) VALUES (5.12, 'blue', 'strict', 82.8, 60);
INSERT INTO stats_logs (weight, label, state, score, rank) VALUES (25.3, 'legacy', 'green', 54.91, 48);
