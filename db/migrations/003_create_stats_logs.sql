-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (label, active, token, ratio) VALUES ('primary', 2, 'stable', 61.81);
INSERT INTO stats_logs (label, active, token, ratio) VALUES ('cached', 56, 'stable', 28.15);
INSERT INTO stats_logs (label, active, token, ratio) VALUES ('strict', 12, 'green', 10.25);
