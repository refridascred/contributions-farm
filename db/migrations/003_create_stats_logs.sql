-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (ratio, label, weight) VALUES (51.87, 'edge', 23.35);
INSERT INTO stats_logs (ratio, label, weight) VALUES (39.09, 'open', 83.43);
INSERT INTO stats_logs (ratio, label, weight) VALUES (63.32, 'edge', 26.03);
