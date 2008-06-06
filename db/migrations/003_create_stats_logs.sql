-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (label, ratio, owner) VALUES ('local', 23.62, 'blue');
INSERT INTO stats_logs (label, ratio, owner) VALUES ('local', 7.0, 'stable');
INSERT INTO stats_logs (label, ratio, owner) VALUES ('edge', 27.24, 'strict');
