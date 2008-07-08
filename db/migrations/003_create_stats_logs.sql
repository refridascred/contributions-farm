-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (count, region, label) VALUES (53, 'local', 'primary');
INSERT INTO stats_logs (count, region, label) VALUES (63, 'blue', 'standard');
INSERT INTO stats_logs (count, region, label) VALUES (3, 'open', 'legacy');
