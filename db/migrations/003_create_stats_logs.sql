-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, active, ratio, rank, token) VALUES ('latest', 31, 97.34, 58, 'cached');
INSERT INTO stats_logs (label, active, ratio, rank, token) VALUES ('latest', 38, 14.42, 22, 'standard');
INSERT INTO stats_logs (label, active, ratio, rank, token) VALUES ('local', 58, 31.72, 55, 'stable');
