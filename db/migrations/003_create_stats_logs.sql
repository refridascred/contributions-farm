-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (ratio, state, score) VALUES (95.13, 'edge', 28.47);
INSERT INTO stats_logs (ratio, state, score) VALUES (36.3, 'primary', 61.74);
INSERT INTO stats_logs (ratio, state, score) VALUES (66.53, 'stable', 0.56);
