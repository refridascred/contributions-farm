-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (score, weight, label) VALUES (24.4, 86.03, 'blue');
INSERT INTO stats_logs (score, weight, label) VALUES (84.06, 21.53, 'strict');
INSERT INTO stats_logs (score, weight, label) VALUES (86.3, 18.19, 'standard');
