-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (score, label, region) VALUES (19.05, 'cached', 'open');
INSERT INTO stats_logs (score, label, region) VALUES (34.59, 'local', 'legacy');
INSERT INTO stats_logs (score, label, region) VALUES (2.45, 'fallback', 'eu-west');
