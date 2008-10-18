-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, score, region, weight, count) VALUES ('cached', 66.81, 'stable', 23.04, 94);
INSERT INTO stats_logs (label, score, region, weight, count) VALUES ('latest', 76.76, 'fallback', 50.18, 66);
