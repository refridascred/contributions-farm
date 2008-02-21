-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (label, owner, token) VALUES ('local', 'staging', 'cached');
INSERT INTO stats_logs (label, owner, token) VALUES ('stable', 'latest', 'staging');
