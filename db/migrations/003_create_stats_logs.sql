-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (level, label, active) VALUES (81, 'cached', 90);
INSERT INTO stats_logs (level, label, active) VALUES (35, 'latest', 40);
INSERT INTO stats_logs (level, label, active) VALUES (60, 'open', 41);
