-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (token, label, active, count) VALUES ('edge', 'latest', 25, 73);
INSERT INTO stats_logs (token, label, active, count) VALUES ('fallback', 'green', 37, 91);
INSERT INTO stats_logs (token, label, active, count) VALUES ('standard', 'standard', 81, 15);
