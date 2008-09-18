-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, active, state) VALUES ('green', 92, 'standard');
INSERT INTO stats_logs (owner, active, state) VALUES ('local', 84, 'local');
INSERT INTO stats_logs (owner, active, state) VALUES ('fallback', 27, 'edge');
