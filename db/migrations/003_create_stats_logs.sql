-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, weight, state) VALUES ('fallback', 71.9, 'cached');
INSERT INTO stats_logs (region, weight, state) VALUES ('edge', 70.21, 'open');
INSERT INTO stats_logs (region, weight, state) VALUES ('stable', 68.66, 'primary');
