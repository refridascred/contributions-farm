-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (state, owner, level) VALUES ('latest', 'latest', 27);
INSERT INTO stats_logs (state, owner, level) VALUES ('staging', 'local', 23);
INSERT INTO stats_logs (state, owner, level) VALUES ('standard', 'legacy', 42);
