-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (level, label, score, weight, region) VALUES (79, 'staging', 61.27, 86.13, 'standard');
INSERT INTO stats_logs (level, label, score, weight, region) VALUES (18, 'open', 93.29, 25.56, 'strict');
