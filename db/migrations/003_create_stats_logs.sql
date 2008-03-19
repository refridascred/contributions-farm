-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, active, token) VALUES ('latest', 62, 'primary');
INSERT INTO stats_logs (label, active, token) VALUES ('blue', 85, 'eu-west');
INSERT INTO stats_logs (label, active, token) VALUES ('cached', 18, 'stable');
