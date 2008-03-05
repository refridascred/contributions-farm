-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (label, state, region, ratio) VALUES ('primary', 'cached', 'fallback', 70.98);
INSERT INTO stats_logs (label, state, region, ratio) VALUES ('open', 'fallback', 'standard', 51.23);
INSERT INTO stats_logs (label, state, region, ratio) VALUES ('open', 'blue', 'fallback', 51.7);
