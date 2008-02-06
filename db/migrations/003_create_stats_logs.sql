-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (state, token, owner, region) VALUES ('stable', 'blue', 'green', 'eu-west');
INSERT INTO stats_logs (state, token, owner, region) VALUES ('blue', 'local', 'blue', 'local');
