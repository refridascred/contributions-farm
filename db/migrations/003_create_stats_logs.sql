-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (weight, state, active, count) VALUES (75.7, 'edge', 60, 57);
INSERT INTO stats_logs (weight, state, active, count) VALUES (44.95, 'legacy', 26, 42);
INSERT INTO stats_logs (weight, state, active, count) VALUES (6.24, 'fallback', 22, 32);
