-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (label, ratio, level) VALUES ('legacy', 65.21, 46);
INSERT INTO stats_logs (label, ratio, level) VALUES ('edge', 61.97, 39);
INSERT INTO stats_logs (label, ratio, level) VALUES ('primary', 62.68, 20);
