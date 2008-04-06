-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (state, count, owner) VALUES ('blue', 37, 'edge');
INSERT INTO stats_logs (state, count, owner) VALUES ('local', 62, 'fallback');
INSERT INTO stats_logs (state, count, owner) VALUES ('standard', 13, 'blue');
