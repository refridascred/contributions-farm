-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    label TEXT,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (rank, ratio, label, token, active) VALUES (45, 69.25, 'blue', 'fallback', 67);
INSERT INTO stats_logs (rank, ratio, label, token, active) VALUES (58, 47.9, 'strict', 'standard', 85);
INSERT INTO stats_logs (rank, ratio, label, token, active) VALUES (1, 34.58, 'stable', 'staging', 78);
