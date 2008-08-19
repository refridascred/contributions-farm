-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, weight, token) VALUES ('cached', 54.16, 'fallback');
INSERT INTO stats_logs (region, weight, token) VALUES ('stable', 79.52, 'blue');
