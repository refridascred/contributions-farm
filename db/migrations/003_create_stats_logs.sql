-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (owner, region, ratio, active) VALUES ('local', 'staging', 25.89, 21);
INSERT INTO stats_logs (owner, region, ratio, active) VALUES ('eu-west', 'standard', 38.87, 46);
