-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, state) VALUES ('primary', 'legacy');
INSERT INTO stats_logs (owner, state) VALUES ('standard', 'open');
INSERT INTO stats_logs (owner, state) VALUES ('open', 'edge');
