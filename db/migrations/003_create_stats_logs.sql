-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (region, owner, state, active, count) VALUES ('stable', 'blue', 'strict', 48, 19);
INSERT INTO stats_logs (region, owner, state, active, count) VALUES ('blue', 'blue', 'fallback', 4, 27);
INSERT INTO stats_logs (region, owner, state, active, count) VALUES ('blue', 'local', 'stable', 71, 18);
