-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (label, region, score, token, active) VALUES ('green', 'staging', 38.74, 'standard', 81);
INSERT INTO stats_logs (label, region, score, token, active) VALUES ('open', 'standard', 76.18, 'green', 15);
INSERT INTO stats_logs (label, region, score, token, active) VALUES ('standard', 'green', 13.29, 'edge', 30);
