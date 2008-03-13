-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, count, state) VALUES (72, 1, 'fallback');
INSERT INTO stats_logs (active, count, state) VALUES (53, 52, 'cached');
INSERT INTO stats_logs (active, count, state) VALUES (72, 96, 'edge');
