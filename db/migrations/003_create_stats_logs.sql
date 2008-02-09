-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    ratio REAL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, weight, ratio, count) VALUES ('legacy', 95.75, 59.81, 37);
INSERT INTO stats_logs (label, weight, ratio, count) VALUES ('standard', 83.77, 41.52, 52);
INSERT INTO stats_logs (label, weight, ratio, count) VALUES ('local', 92.82, 43.71, 40);
