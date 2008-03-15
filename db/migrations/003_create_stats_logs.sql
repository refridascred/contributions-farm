-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (state, count, score, region) VALUES ('edge', 48, 13.67, 'green');
INSERT INTO stats_logs (state, count, score, region) VALUES ('standard', 24, 60.96, 'fallback');
INSERT INTO stats_logs (state, count, score, region) VALUES ('cached', 67, 31.28, 'latest');
