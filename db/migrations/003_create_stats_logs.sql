-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (count, region, active) VALUES (10, 'local', 46);
INSERT INTO stats_logs (count, region, active) VALUES (49, 'blue', 67);
INSERT INTO stats_logs (count, region, active) VALUES (27, 'standard', 87);
