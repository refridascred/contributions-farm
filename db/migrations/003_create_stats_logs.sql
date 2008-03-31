-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (weight, region, state, level) VALUES (26.47, 'green', 'strict', 8);
INSERT INTO stats_logs (weight, region, state, level) VALUES (90.45, 'stable', 'standard', 78);
INSERT INTO stats_logs (weight, region, state, level) VALUES (9.59, 'local', 'staging', 15);
