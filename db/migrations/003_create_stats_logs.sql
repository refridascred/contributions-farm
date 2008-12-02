-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    level INTEGER,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (state, region, level, token, score) VALUES ('fallback', 'eu-west', 4, 'cached', 72.86);
INSERT INTO stats_logs (state, region, level, token, score) VALUES ('standard', 'edge', 55, 'cached', 34.48);
