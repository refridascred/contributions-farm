-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (ratio, state, owner, count) VALUES (8.37, 'legacy', 'open', 42);
INSERT INTO stats_logs (ratio, state, owner, count) VALUES (98.38, 'primary', 'edge', 54);
INSERT INTO stats_logs (ratio, state, owner, count) VALUES (73.05, 'edge', 'eu-west', 27);
