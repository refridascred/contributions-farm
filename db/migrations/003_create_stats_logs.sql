-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, state, level, weight) VALUES (80.65, 'staging', 95, 14.31);
INSERT INTO stats_logs (ratio, state, level, weight) VALUES (8.85, 'local', 96, 73.16);
INSERT INTO stats_logs (ratio, state, level, weight) VALUES (40.13, 'fallback', 80, 0.62);
