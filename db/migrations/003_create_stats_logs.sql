-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, owner, label) VALUES ('local', 'edge', 'staging');
INSERT INTO stats_logs (token, owner, label) VALUES ('local', 'staging', 'legacy');
INSERT INTO stats_logs (token, owner, label) VALUES ('stable', 'eu-west', 'primary');
