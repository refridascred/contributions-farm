-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, weight, score, region, active) VALUES ('green', 0.58, 48.78, 'staging', 37);
INSERT INTO stats_logs (label, weight, score, region, active) VALUES ('legacy', 82.95, 87.29, 'open', 76);
