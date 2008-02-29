-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (owner, ratio, count) VALUES ('staging', 35.97, 83);
INSERT INTO stats_logs (owner, ratio, count) VALUES ('blue', 7.87, 87);
INSERT INTO stats_logs (owner, ratio, count) VALUES ('edge', 13.25, 42);
