-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    label TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (token, ratio, label, level, active) VALUES ('blue', 77.37, 'standard', 64, 59);
INSERT INTO stats_logs (token, ratio, label, level, active) VALUES ('legacy', 51.78, 'green', 83, 16);
