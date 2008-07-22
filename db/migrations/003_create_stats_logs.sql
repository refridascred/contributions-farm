-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (label, active, count) VALUES ('green', 12, 30);
INSERT INTO stats_logs (label, active, count) VALUES ('staging', 16, 73);
INSERT INTO stats_logs (label, active, count) VALUES ('cached', 26, 44);
