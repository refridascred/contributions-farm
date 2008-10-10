-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, owner) VALUES ('fallback', 'fallback');
INSERT INTO stats_logs (token, owner) VALUES ('eu-west', 'cached');
INSERT INTO stats_logs (token, owner) VALUES ('edge', 'green');
