-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (count, ratio, active) VALUES (17, 68.46, 1);
INSERT INTO stats_logs (count, ratio, active) VALUES (21, 4.55, 91);
INSERT INTO stats_logs (count, ratio, active) VALUES (20, 90.35, 95);
