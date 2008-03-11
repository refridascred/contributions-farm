-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (ratio, token, count, active, state) VALUES (51.96, 'stable', 10, 69, 'standard');
INSERT INTO stats_logs (ratio, token, count, active, state) VALUES (93.74, 'eu-west', 91, 38, 'open');
INSERT INTO stats_logs (ratio, token, count, active, state) VALUES (32.66, 'legacy', 14, 5, 'cached');
