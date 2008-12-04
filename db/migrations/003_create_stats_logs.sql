-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (token, active, owner) VALUES ('latest', 78, 'eu-west');
INSERT INTO stats_logs (token, active, owner) VALUES ('fallback', 27, 'latest');
INSERT INTO stats_logs (token, active, owner) VALUES ('staging', 51, 'staging');
