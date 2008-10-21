-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, weight, count) VALUES ('eu-west', 35.83, 25);
INSERT INTO stats_logs (label, weight, count) VALUES ('strict', 38.62, 17);
INSERT INTO stats_logs (label, weight, count) VALUES ('open', 36.31, 16);
