-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (token, state, owner, level) VALUES ('blue', 'standard', 'cached', 39);
INSERT INTO stats_logs (token, state, owner, level) VALUES ('latest', 'local', 'staging', 44);
INSERT INTO stats_logs (token, state, owner, level) VALUES ('open', 'open', 'staging', 12);
