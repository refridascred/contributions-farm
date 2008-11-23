-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (label, active, rank, level, state) VALUES ('blue', 5, 85, 90, 'strict');
INSERT INTO stats_logs (label, active, rank, level, state) VALUES ('staging', 22, 29, 33, 'open');
INSERT INTO stats_logs (label, active, rank, level, state) VALUES ('edge', 1, 39, 76, 'blue');
