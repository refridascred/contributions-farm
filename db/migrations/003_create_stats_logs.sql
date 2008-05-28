-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (level, count, label) VALUES (43, 91, 'blue');
INSERT INTO stats_logs (level, count, label) VALUES (60, 97, 'open');
INSERT INTO stats_logs (level, count, label) VALUES (58, 87, 'local');
