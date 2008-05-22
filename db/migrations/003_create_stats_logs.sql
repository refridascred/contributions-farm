-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (level, label, active) VALUES (19, 'eu-west', 73);
INSERT INTO stats_logs (level, label, active) VALUES (65, 'primary', 92);
INSERT INTO stats_logs (level, label, active) VALUES (24, 'fallback', 75);
