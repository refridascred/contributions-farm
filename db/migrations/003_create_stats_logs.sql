-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (token, active, owner) VALUES ('cached', 22, 'cached');
INSERT INTO stats_logs (token, active, owner) VALUES ('latest', 41, 'standard');
INSERT INTO stats_logs (token, active, owner) VALUES ('open', 96, 'stable');
