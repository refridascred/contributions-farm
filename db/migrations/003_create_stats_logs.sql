-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (level, count, state, label) VALUES (60, 33, 'standard', 'local');
INSERT INTO stats_logs (level, count, state, label) VALUES (65, 9, 'stable', 'latest');
INSERT INTO stats_logs (level, count, state, label) VALUES (18, 47, 'cached', 'edge');
