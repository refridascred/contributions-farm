-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (weight, count, label, region, state) VALUES (75.88, 43, 'fallback', 'edge', 'local');
INSERT INTO stats_logs (weight, count, label, region, state) VALUES (11.62, 98, 'green', 'open', 'primary');
