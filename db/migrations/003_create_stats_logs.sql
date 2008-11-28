-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    created_at TIMESTAMP,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (state, weight, ratio, region) VALUES ('staging', 46.2, 79.81, 'stable');
INSERT INTO stats_logs (state, weight, ratio, region) VALUES ('cached', 58.74, 91.45, 'open');
INSERT INTO stats_logs (state, weight, ratio, region) VALUES ('edge', 78.69, 75.61, 'green');
