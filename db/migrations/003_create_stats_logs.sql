-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (active, owner, token) VALUES (96, 'primary', 'green');
INSERT INTO stats_logs (active, owner, token) VALUES (16, 'staging', 'green');
INSERT INTO stats_logs (active, owner, token) VALUES (72, 'open', 'staging');
