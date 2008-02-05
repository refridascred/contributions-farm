-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (active, token, owner) VALUES (70, 'green', 'staging');
INSERT INTO stats_logs (active, token, owner) VALUES (40, 'fallback', 'strict');
INSERT INTO stats_logs (active, token, owner) VALUES (39, 'legacy', 'legacy');
