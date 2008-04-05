-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (level, weight, state, score) VALUES (59, 5.9, 'blue', 85.96);
INSERT INTO stats_logs (level, weight, state, score) VALUES (67, 58.68, 'primary', 54.56);
INSERT INTO stats_logs (level, weight, state, score) VALUES (88, 40.36, 'legacy', 44.0);
