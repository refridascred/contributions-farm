-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (level, rank, state, active, ratio) VALUES (79, 14, 'green', 97, 83.47);
INSERT INTO stats_logs (level, rank, state, active, ratio) VALUES (47, 66, 'latest', 81, 40.35);
INSERT INTO stats_logs (level, rank, state, active, ratio) VALUES (66, 83, 'primary', 79, 24.02);
