-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, active, level, ratio) VALUES ('stable', 6, 40, 64.6);
INSERT INTO stats_logs (state, active, level, ratio) VALUES ('blue', 6, 39, 4.97);
INSERT INTO stats_logs (state, active, level, ratio) VALUES ('standard', 81, 54, 55.95);
