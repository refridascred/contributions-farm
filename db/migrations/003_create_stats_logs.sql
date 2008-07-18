-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (score, label, level) VALUES (38.68, 'staging', 27);
INSERT INTO stats_logs (score, label, level) VALUES (28.18, 'primary', 60);
INSERT INTO stats_logs (score, label, level) VALUES (85.94, 'edge', 98);
