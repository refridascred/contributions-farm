-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, ratio, rank, state, region) VALUES (93.79, 89.74, 68, 'legacy', 'strict');
INSERT INTO stats_logs (score, ratio, rank, state, region) VALUES (95.32, 80.97, 66, 'local', 'standard');
