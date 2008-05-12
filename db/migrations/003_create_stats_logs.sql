-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (label, owner, token) VALUES ('primary', 'strict', 'latest');
INSERT INTO stats_logs (label, owner, token) VALUES ('fallback', 'latest', 'strict');
