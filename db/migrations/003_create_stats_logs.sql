-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (region, label, ratio) VALUES ('cached', 'edge', 8.53);
INSERT INTO stats_logs (region, label, ratio) VALUES ('edge', 'standard', 41.9);
INSERT INTO stats_logs (region, label, ratio) VALUES ('eu-west', 'open', 16.44);
