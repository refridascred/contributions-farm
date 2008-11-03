-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (label, score, region) VALUES ('standard', 33.7, 'primary');
INSERT INTO stats_logs (label, score, region) VALUES ('open', 82.01, 'eu-west');
INSERT INTO stats_logs (label, score, region) VALUES ('legacy', 81.29, 'cached');
