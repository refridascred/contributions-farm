-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (label, region, score, count) VALUES ('primary', 'strict', 91.49, 28);
INSERT INTO stats_logs (label, region, score, count) VALUES ('green', 'green', 48.11, 28);
INSERT INTO stats_logs (label, region, score, count) VALUES ('latest', 'blue', 74.39, 88);
