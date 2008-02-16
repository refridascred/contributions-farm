-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, weight, score, count, token) VALUES ('staging', 55.87, 79.88, 44, 'eu-west');
INSERT INTO stats_logs (region, weight, score, count, token) VALUES ('fallback', 38.65, 94.83, 84, 'open');
INSERT INTO stats_logs (region, weight, score, count, token) VALUES ('cached', 29.22, 50.1, 60, 'legacy');
