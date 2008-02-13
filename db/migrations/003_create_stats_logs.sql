-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    owner TEXT NOT NULL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (label, level, owner, token, active) VALUES ('edge', 24, 'open', 'primary', 71);
INSERT INTO stats_logs (label, level, owner, token, active) VALUES ('legacy', 77, 'staging', 'blue', 91);
INSERT INTO stats_logs (label, level, owner, token, active) VALUES ('strict', 64, 'cached', 'blue', 89);
