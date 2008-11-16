-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (level, count, label, token, region) VALUES (4, 51, 'standard', 'eu-west', 'green');
INSERT INTO stats_logs (level, count, label, token, region) VALUES (89, 39, 'stable', 'legacy', 'staging');
