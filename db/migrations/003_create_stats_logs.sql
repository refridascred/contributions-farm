-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    region TEXT,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (ratio, region, weight, active) VALUES (21.84, 'standard', 88.13, 53);
INSERT INTO stats_logs (ratio, region, weight, active) VALUES (45.95, 'strict', 8.04, 74);
INSERT INTO stats_logs (ratio, region, weight, active) VALUES (26.68, 'fallback', 97.78, 65);
