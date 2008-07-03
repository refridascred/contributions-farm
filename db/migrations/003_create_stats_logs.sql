-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, state, region) VALUES ('blue', 'strict', 'strict');
INSERT INTO stats_logs (token, state, region) VALUES ('legacy', 'primary', 'primary');
INSERT INTO stats_logs (token, state, region) VALUES ('primary', 'local', 'eu-west');
