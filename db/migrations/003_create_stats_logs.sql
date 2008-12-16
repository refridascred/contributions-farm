-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (active, level, token, label) VALUES (61, 85, 'edge', 'edge');
INSERT INTO stats_logs (active, level, token, label) VALUES (50, 84, 'cached', 'stable');
