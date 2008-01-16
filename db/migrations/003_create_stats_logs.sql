-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, token, count) VALUES ('green', 'local', 53);
INSERT INTO stats_logs (owner, token, count) VALUES ('standard', 'legacy', 50);
INSERT INTO stats_logs (owner, token, count) VALUES ('stable', 'fallback', 48);
