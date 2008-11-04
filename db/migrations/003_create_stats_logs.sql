-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (weight, count) VALUES (58.54, 24);
INSERT INTO stats_logs (weight, count) VALUES (40.39, 68);
INSERT INTO stats_logs (weight, count) VALUES (43.22, 85);
