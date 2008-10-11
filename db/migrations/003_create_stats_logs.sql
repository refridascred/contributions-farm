-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (score, label, count) VALUES (68.4, 'staging', 82);
INSERT INTO stats_logs (score, label, count) VALUES (10.37, 'latest', 66);
INSERT INTO stats_logs (score, label, count) VALUES (28.24, 'primary', 15);
