-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, score, count) VALUES ('cached', 52.14, 31);
INSERT INTO stats_logs (label, score, count) VALUES ('strict', 86.28, 85);
INSERT INTO stats_logs (label, score, count) VALUES ('primary', 2.04, 64);
