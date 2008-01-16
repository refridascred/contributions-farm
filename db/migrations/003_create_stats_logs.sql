-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, score, weight, label, region) VALUES (38, 66.42, 84.32, 'edge', 'cached');
INSERT INTO stats_logs (active, score, weight, label, region) VALUES (6, 62.5, 64.78, 'green', 'stable');
