-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (weight, level, region, state) VALUES (67.1, 60, 'open', 'strict');
INSERT INTO stats_logs (weight, level, region, state) VALUES (19.0, 13, 'stable', 'staging');
INSERT INTO stats_logs (weight, level, region, state) VALUES (61.13, 21, 'green', 'green');
