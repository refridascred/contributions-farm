-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (score, token) VALUES (97.95, 'local');
INSERT INTO stats_logs (score, token) VALUES (83.81, 'eu-west');
INSERT INTO stats_logs (score, token) VALUES (21.87, 'open');
