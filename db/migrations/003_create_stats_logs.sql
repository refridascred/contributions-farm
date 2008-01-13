-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (owner, label, token) VALUES ('edge', 'local', 'legacy');
INSERT INTO stats_logs (owner, label, token) VALUES ('stable', 'green', 'primary');
