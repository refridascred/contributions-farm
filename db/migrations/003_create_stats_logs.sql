-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, region, owner, state) VALUES ('local', 'standard', 'stable', 'eu-west');
INSERT INTO stats_logs (token, region, owner, state) VALUES ('blue', 'latest', 'edge', 'primary');
