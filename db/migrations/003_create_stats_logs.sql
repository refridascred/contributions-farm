-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (region, count, label, weight) VALUES ('blue', 93, 'stable', 13.38);
INSERT INTO stats_logs (region, count, label, weight) VALUES ('local', 19, 'blue', 34.78);
