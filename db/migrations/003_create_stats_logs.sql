-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, weight, active, owner) VALUES ('blue', 87.48, 49, 'stable');
INSERT INTO stats_logs (state, weight, active, owner) VALUES ('legacy', 36.13, 73, 'legacy');
INSERT INTO stats_logs (state, weight, active, owner) VALUES ('local', 38.33, 13, 'standard');
