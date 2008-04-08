-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (state, region, count, weight, token) VALUES ('latest', 'primary', 31, 9.2, 'fallback');
INSERT INTO stats_logs (state, region, count, weight, token) VALUES ('fallback', 'primary', 75, 72.3, 'staging');
