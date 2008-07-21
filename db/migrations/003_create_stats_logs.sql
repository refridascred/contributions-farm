-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (rank, level, state, active) VALUES (77, 68, 'primary', 76);
INSERT INTO stats_logs (rank, level, state, active) VALUES (9, 80, 'fallback', 30);
INSERT INTO stats_logs (rank, level, state, active) VALUES (51, 36, 'latest', 29);
