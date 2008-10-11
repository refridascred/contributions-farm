-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, active, token) VALUES ('open', 90, 'staging');
INSERT INTO stats_logs (owner, active, token) VALUES ('edge', 60, 'primary');
INSERT INTO stats_logs (owner, active, token) VALUES ('eu-west', 9, 'strict');
