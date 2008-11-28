-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (region, level, state, count, active) VALUES ('blue', 31, 'staging', 50, 47);
INSERT INTO stats_logs (region, level, state, count, active) VALUES ('cached', 45, 'edge', 52, 66);
INSERT INTO stats_logs (region, level, state, count, active) VALUES ('stable', 68, 'primary', 69, 96);
