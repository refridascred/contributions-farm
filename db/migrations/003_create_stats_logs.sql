-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (region, label, weight, ratio) VALUES ('open', 'latest', 94.31, 42.46);
INSERT INTO stats_logs (region, label, weight, ratio) VALUES ('local', 'edge', 91.05, 55.09);
INSERT INTO stats_logs (region, label, weight, ratio) VALUES ('standard', 'fallback', 96.25, 23.25);
