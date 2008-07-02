-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (rank, score, state, label) VALUES (60, 83.7, 'green', 'strict');
INSERT INTO stats_logs (rank, score, state, label) VALUES (7, 77.78, 'edge', 'open');
INSERT INTO stats_logs (rank, score, state, label) VALUES (45, 92.89, 'stable', 'strict');
