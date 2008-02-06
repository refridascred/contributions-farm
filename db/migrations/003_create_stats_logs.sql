-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (token, active, owner, level, label) VALUES ('edge', 29, 'latest', 2, 'primary');
INSERT INTO stats_logs (token, active, owner, level, label) VALUES ('cached', 72, 'staging', 31, 'edge');
INSERT INTO stats_logs (token, active, owner, level, label) VALUES ('staging', 88, 'primary', 55, 'staging');
