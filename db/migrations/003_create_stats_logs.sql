-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (level, active, state, owner, rank) VALUES (22, 48, 'edge', 'primary', 41);
INSERT INTO stats_logs (level, active, state, owner, rank) VALUES (55, 36, 'legacy', 'cached', 8);
