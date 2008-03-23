-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (label, count, active, ratio) VALUES ('eu-west', 6, 35, 96.81);
INSERT INTO stats_logs (label, count, active, ratio) VALUES ('eu-west', 52, 80, 5.58);
INSERT INTO stats_logs (label, count, active, ratio) VALUES ('fallback', 21, 62, 5.4);
