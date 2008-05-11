-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (active, owner, state) VALUES (77, 'latest', 'strict');
INSERT INTO stats_logs (active, owner, state) VALUES (28, 'standard', 'latest');
INSERT INTO stats_logs (active, owner, state) VALUES (70, 'primary', 'stable');
