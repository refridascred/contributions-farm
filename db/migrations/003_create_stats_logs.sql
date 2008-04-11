-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    weight REAL,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (token, level, weight, label, ratio) VALUES ('eu-west', 31, 59.42, 'staging', 89.29);
INSERT INTO stats_logs (token, level, weight, label, ratio) VALUES ('strict', 1, 73.02, 'stable', 21.99);
INSERT INTO stats_logs (token, level, weight, label, ratio) VALUES ('edge', 9, 43.75, 'standard', 8.34);
