-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (token, active, region) VALUES ('standard', 66, 'green');
INSERT INTO stats_logs (token, active, region) VALUES ('fallback', 15, 'green');
INSERT INTO stats_logs (token, active, region) VALUES ('primary', 34, 'cached');
