-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, count, ratio, weight) VALUES ('stable', 37, 33.0, 64.1);
INSERT INTO stats_logs (label, count, ratio, weight) VALUES ('cached', 10, 3.4, 64.84);
INSERT INTO stats_logs (label, count, ratio, weight) VALUES ('stable', 52, 79.24, 2.59);
