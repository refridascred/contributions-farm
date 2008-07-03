-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (region, weight, state, score) VALUES ('standard', 70.54, 'fallback', 33.23);
INSERT INTO stats_logs (region, weight, state, score) VALUES ('green', 17.74, 'cached', 42.29);
