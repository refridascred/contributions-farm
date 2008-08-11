-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, owner, token) VALUES ('edge', 'eu-west', 'green');
INSERT INTO stats_logs (region, owner, token) VALUES ('primary', 'fallback', 'edge');
