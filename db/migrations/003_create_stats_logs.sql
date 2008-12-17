-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    created_at TIMESTAMP,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (ratio, weight, label, rank) VALUES (63.39, 42.9, 'stable', 16);
INSERT INTO stats_logs (ratio, weight, label, rank) VALUES (66.74, 24.32, 'cached', 20);
INSERT INTO stats_logs (ratio, weight, label, rank) VALUES (62.46, 72.19, 'fallback', 83);
