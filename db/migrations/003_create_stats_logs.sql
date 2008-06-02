-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (owner, count, state, level) VALUES ('blue', 73, 'primary', 29);
INSERT INTO stats_logs (owner, count, state, level) VALUES ('standard', 0, 'strict', 15);
INSERT INTO stats_logs (owner, count, state, level) VALUES ('fallback', 57, 'edge', 94);
