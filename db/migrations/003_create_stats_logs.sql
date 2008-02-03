-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (region, active, ratio, owner) VALUES ('green', 54, 59.68, 'cached');
INSERT INTO stats_logs (region, active, ratio, owner) VALUES ('primary', 73, 94.31, 'latest');
