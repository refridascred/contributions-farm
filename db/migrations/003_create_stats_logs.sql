-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    region TEXT,
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (count, label, region, level) VALUES (78, 'blue', 'open', 32);
INSERT INTO stats_logs (count, label, region, level) VALUES (44, 'edge', 'blue', 91);
INSERT INTO stats_logs (count, label, region, level) VALUES (8, 'primary', 'blue', 18);
