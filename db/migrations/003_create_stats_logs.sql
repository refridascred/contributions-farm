-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (active, state, level, rank, token) VALUES (16, 'green', 96, 88, 'edge');
INSERT INTO stats_logs (active, state, level, rank, token) VALUES (0, 'blue', 81, 98, 'green');
