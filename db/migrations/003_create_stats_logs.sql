-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (state, ratio, region, label) VALUES ('stable', 75.91, 'legacy', 'local');
INSERT INTO stats_logs (state, ratio, region, label) VALUES ('cached', 83.27, 'green', 'primary');
INSERT INTO stats_logs (state, ratio, region, label) VALUES ('strict', 14.57, 'standard', 'standard');
