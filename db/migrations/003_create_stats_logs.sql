-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, active, state) VALUES ('local', 49, 'open');
INSERT INTO stats_logs (owner, active, state) VALUES ('eu-west', 30, 'open');
INSERT INTO stats_logs (owner, active, state) VALUES ('strict', 9, 'legacy');
