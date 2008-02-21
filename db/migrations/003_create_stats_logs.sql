-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (weight, token, score, state) VALUES (35.83, 'edge', 76.25, 'legacy');
INSERT INTO stats_logs (weight, token, score, state) VALUES (81.5, 'staging', 27.47, 'fallback');
INSERT INTO stats_logs (weight, token, score, state) VALUES (70.38, 'legacy', 42.43, 'latest');
