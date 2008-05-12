-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, score, state, weight, count) VALUES (61.58, 54.9, 'latest', 16.03, 60);
INSERT INTO stats_logs (ratio, score, state, weight, count) VALUES (19.6, 72.18, 'strict', 49.52, 30);
INSERT INTO stats_logs (ratio, score, state, weight, count) VALUES (84.6, 19.92, 'strict', 36.75, 87);
