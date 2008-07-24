-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (weight, ratio, score) VALUES (40.0, 94.63, 40.28);
INSERT INTO stats_logs (weight, ratio, score) VALUES (34.7, 32.08, 84.89);
INSERT INTO stats_logs (weight, ratio, score) VALUES (65.27, 68.35, 46.46);
