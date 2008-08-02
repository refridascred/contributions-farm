-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (owner, state) VALUES ('local', 'staging');
INSERT INTO stats_logs (owner, state) VALUES ('primary', 'cached');
INSERT INTO stats_logs (owner, state) VALUES ('staging', 'strict');
