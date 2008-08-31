-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (active, token, state, level) VALUES (73, 'edge', 'cached', 12);
INSERT INTO stats_logs (active, token, state, level) VALUES (45, 'local', 'latest', 33);
INSERT INTO stats_logs (active, token, state, level) VALUES (4, 'standard', 'blue', 14);
