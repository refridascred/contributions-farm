-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (ratio, active, rank, level, label) VALUES (11.13, 26, 58, 17, 'cached');
INSERT INTO stats_logs (ratio, active, rank, level, label) VALUES (40.64, 47, 17, 62, 'primary');
INSERT INTO stats_logs (ratio, active, rank, level, label) VALUES (33.39, 71, 45, 68, 'eu-west');
