-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (count, label, active, level) VALUES (98, 'strict', 59, 66);
INSERT INTO stats_logs (count, label, active, level) VALUES (35, 'standard', 88, 8);
INSERT INTO stats_logs (count, label, active, level) VALUES (58, 'eu-west', 47, 2);
