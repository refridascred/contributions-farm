-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (level, ratio, state, region, score) VALUES (47, 72.52, 'green', 'open', 96.66);
INSERT INTO stats_logs (level, ratio, state, region, score) VALUES (44, 95.33, 'green', 'fallback', 92.75);
INSERT INTO stats_logs (level, ratio, state, region, score) VALUES (28, 59.91, 'eu-west', 'blue', 60.2);
