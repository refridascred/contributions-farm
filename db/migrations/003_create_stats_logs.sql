-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (active, weight, token, owner) VALUES (34, 21.7, 'fallback', 'blue');
INSERT INTO stats_logs (active, weight, token, owner) VALUES (58, 0.55, 'staging', 'green');
INSERT INTO stats_logs (active, weight, token, owner) VALUES (52, 9.58, 'cached', 'green');
