-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (active, weight, state, region, ratio) VALUES (16, 4.77, 'green', 'green', 26.39);
INSERT INTO stats_logs (active, weight, state, region, ratio) VALUES (82, 10.44, 'strict', 'cached', 90.09);
INSERT INTO stats_logs (active, weight, state, region, ratio) VALUES (41, 81.04, 'cached', 'fallback', 17.19);
