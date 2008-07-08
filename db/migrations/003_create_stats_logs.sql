-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, ratio, state, count, score) VALUES (76.76, 92.79, 'legacy', 77, 41.53);
INSERT INTO stats_logs (weight, ratio, state, count, score) VALUES (50.7, 47.72, 'primary', 55, 40.87);
