-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, label, token) VALUES ('latest', 'edge', 'fallback');
INSERT INTO stats_logs (region, label, token) VALUES ('eu-west', 'green', 'eu-west');
INSERT INTO stats_logs (region, label, token) VALUES ('primary', 'strict', 'standard');
