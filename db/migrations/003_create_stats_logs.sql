-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (active, label, count, level) VALUES (82, 'fallback', 84, 12);
INSERT INTO stats_logs (active, label, count, level) VALUES (31, 'open', 46, 77);
INSERT INTO stats_logs (active, label, count, level) VALUES (73, 'standard', 35, 16);
