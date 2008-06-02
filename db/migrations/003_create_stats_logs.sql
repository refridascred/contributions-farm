-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    ratio REAL,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (score, label, ratio, region, owner) VALUES (28.34, 'staging', 21.82, 'cached', 'cached');
INSERT INTO stats_logs (score, label, ratio, region, owner) VALUES (76.92, 'edge', 47.97, 'latest', 'edge');
INSERT INTO stats_logs (score, label, ratio, region, owner) VALUES (61.08, 'edge', 84.69, 'cached', 'open');
