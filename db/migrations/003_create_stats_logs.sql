-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (region, level, state, weight) VALUES ('primary', 90, 'standard', 39.94);
INSERT INTO stats_logs (region, level, state, weight) VALUES ('fallback', 64, 'standard', 60.72);
INSERT INTO stats_logs (region, level, state, weight) VALUES ('stable', 56, 'open', 4.24);
