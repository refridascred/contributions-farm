-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (token, label, active, level) VALUES ('standard', 'latest', 96, 78);
INSERT INTO stats_logs (token, label, active, level) VALUES ('fallback', 'legacy', 11, 40);
INSERT INTO stats_logs (token, label, active, level) VALUES ('staging', 'standard', 53, 38);
