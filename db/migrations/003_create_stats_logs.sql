-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, count, region) VALUES ('blue', 34, 'stable');
INSERT INTO stats_logs (label, count, region) VALUES ('fallback', 16, 'edge');
INSERT INTO stats_logs (label, count, region) VALUES ('open', 5, 'stable');
