-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    region TEXT,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (token, weight, region, label, state) VALUES ('stable', 72.47, 'staging', 'legacy', 'edge');
INSERT INTO stats_logs (token, weight, region, label, state) VALUES ('primary', 0.67, 'strict', 'strict', 'blue');
