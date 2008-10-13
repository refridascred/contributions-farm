-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (owner, token, ratio) VALUES ('open', 'staging', 31.12);
INSERT INTO stats_logs (owner, token, ratio) VALUES ('latest', 'fallback', 42.36);
INSERT INTO stats_logs (owner, token, ratio) VALUES ('standard', 'stable', 67.23);
