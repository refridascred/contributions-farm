-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    label TEXT,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (score, ratio, label, rank, state) VALUES (92.88, 70.97, 'legacy', 11, 'legacy');
INSERT INTO stats_logs (score, ratio, label, rank, state) VALUES (39.82, 20.3, 'legacy', 81, 'green');
