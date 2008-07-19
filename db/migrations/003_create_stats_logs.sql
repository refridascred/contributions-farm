-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (state, ratio, level, active) VALUES ('blue', 9.71, 32, 9);
INSERT INTO stats_logs (state, ratio, level, active) VALUES ('cached', 16.8, 55, 3);
INSERT INTO stats_logs (state, ratio, level, active) VALUES ('open', 47.16, 83, 65);
