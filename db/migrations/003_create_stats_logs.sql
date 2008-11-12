-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, level, state) VALUES (5, 80, 'stable');
INSERT INTO stats_logs (active, level, state) VALUES (25, 52, 'local');
INSERT INTO stats_logs (active, level, state) VALUES (61, 47, 'stable');
