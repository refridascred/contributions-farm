-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (score, region, label) VALUES (48.97, 'open', 'latest');
INSERT INTO stats_logs (score, region, label) VALUES (19.81, 'fallback', 'edge');
INSERT INTO stats_logs (score, region, label) VALUES (0.0, 'legacy', 'legacy');
