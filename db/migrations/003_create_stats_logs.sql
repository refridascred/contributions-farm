-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (ratio, count) VALUES (6.71, 48);
INSERT INTO stats_logs (ratio, count) VALUES (49.95, 44);
INSERT INTO stats_logs (ratio, count) VALUES (52.21, 46);
