-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, region, weight, active) VALUES ('blue', 'legacy', 79.13, 83);
INSERT INTO stats_logs (owner, region, weight, active) VALUES ('latest', 'local', 65.32, 67);
