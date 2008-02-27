-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, count, weight, state) VALUES (88.66, 66, 45.27, 'fallback');
INSERT INTO stats_logs (score, count, weight, state) VALUES (1.65, 91, 94.66, 'cached');
INSERT INTO stats_logs (score, count, weight, state) VALUES (52.36, 42, 2.34, 'fallback');
