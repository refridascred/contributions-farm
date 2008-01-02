-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (region, score, ratio, label) VALUES ('legacy', 50.34, 83.88, 'edge');
INSERT INTO stats_logs (region, score, ratio, label) VALUES ('fallback', 94.59, 19.68, 'blue');
