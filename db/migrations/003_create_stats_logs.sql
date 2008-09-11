-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (active, label, token, ratio) VALUES (52, 'green', 'open', 95.7);
INSERT INTO stats_logs (active, label, token, ratio) VALUES (30, 'standard', 'fallback', 7.21);
