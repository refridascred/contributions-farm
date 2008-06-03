-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (owner, region, ratio, score, label) VALUES ('staging', 'latest', 72.02, 38.39, 'local');
INSERT INTO stats_logs (owner, region, ratio, score, label) VALUES ('fallback', 'cached', 49.66, 79.07, 'cached');
