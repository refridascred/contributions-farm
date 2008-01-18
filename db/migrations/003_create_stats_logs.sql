-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (rank, state, weight, count, active) VALUES (23, 'cached', 11.61, 39, 98);
INSERT INTO stats_logs (rank, state, weight, count, active) VALUES (19, 'staging', 46.8, 52, 37);
INSERT INTO stats_logs (rank, state, weight, count, active) VALUES (8, 'standard', 44.68, 12, 22);
