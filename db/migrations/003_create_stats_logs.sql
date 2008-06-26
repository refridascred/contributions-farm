-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (state, ratio, weight) VALUES ('green', 79.1, 96.42);
INSERT INTO stats_logs (state, ratio, weight) VALUES ('strict', 33.11, 17.02);
INSERT INTO stats_logs (state, ratio, weight) VALUES ('edge', 40.81, 81.61);
