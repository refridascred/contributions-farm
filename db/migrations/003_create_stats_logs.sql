-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (count, state, active) VALUES (70, 'green', 90);
INSERT INTO stats_logs (count, state, active) VALUES (73, 'fallback', 60);
INSERT INTO stats_logs (count, state, active) VALUES (59, 'latest', 33);
