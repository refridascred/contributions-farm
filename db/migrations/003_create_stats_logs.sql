-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (rank, state, weight, active, label) VALUES (48, 'standard', 97.51, 91, 'local');
INSERT INTO stats_logs (rank, state, weight, active, label) VALUES (38, 'blue', 63.36, 14, 'fallback');
INSERT INTO stats_logs (rank, state, weight, active, label) VALUES (65, 'stable', 96.33, 39, 'primary');
