-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (level, state, owner) VALUES (0, 'staging', 'blue');
INSERT INTO stats_logs (level, state, owner) VALUES (53, 'fallback', 'strict');
INSERT INTO stats_logs (level, state, owner) VALUES (70, 'standard', 'blue');
