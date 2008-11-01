-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, token, count) VALUES ('standard', 'edge', 81);
INSERT INTO stats_logs (label, token, count) VALUES ('staging', 'primary', 0);
INSERT INTO stats_logs (label, token, count) VALUES ('legacy', 'primary', 5);
