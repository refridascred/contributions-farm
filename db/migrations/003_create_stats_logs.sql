-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (owner, token, count) VALUES ('blue', 'primary', 90);
INSERT INTO stats_logs (owner, token, count) VALUES ('staging', 'fallback', 3);
INSERT INTO stats_logs (owner, token, count) VALUES ('strict', 'blue', 51);
