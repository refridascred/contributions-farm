-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (level, active, label) VALUES (6, 38, 'green');
INSERT INTO stats_logs (level, active, label) VALUES (3, 29, 'cached');
INSERT INTO stats_logs (level, active, label) VALUES (3, 20, 'cached');
