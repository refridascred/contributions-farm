-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    region TEXT,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (level, label, region, token) VALUES (30, 'local', 'standard', 'open');
INSERT INTO stats_logs (level, label, region, token) VALUES (26, 'eu-west', 'latest', 'open');
INSERT INTO stats_logs (level, label, region, token) VALUES (14, 'blue', 'legacy', 'legacy');
