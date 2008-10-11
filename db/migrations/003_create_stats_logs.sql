-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (active, state, owner) VALUES (39, 'primary', 'strict');
INSERT INTO stats_logs (active, state, owner) VALUES (89, 'cached', 'fallback');
INSERT INTO stats_logs (active, state, owner) VALUES (36, 'edge', 'staging');
