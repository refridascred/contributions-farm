-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (region, state, count, weight, score) VALUES ('local', 'edge', 6, 32.75, 15.06);
INSERT INTO stats_logs (region, state, count, weight, score) VALUES ('blue', 'local', 45, 15.13, 34.72);
INSERT INTO stats_logs (region, state, count, weight, score) VALUES ('green', 'green', 45, 18.71, 8.78);
