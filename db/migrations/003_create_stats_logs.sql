-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, label, region) VALUES ('stable', 'primary', 'eu-west');
INSERT INTO stats_logs (owner, label, region) VALUES ('local', 'cached', 'local');
INSERT INTO stats_logs (owner, label, region) VALUES ('latest', 'edge', 'standard');
