-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, level, weight, state) VALUES (83.71, 58, 85.42, 'local');
INSERT INTO stats_logs (ratio, level, weight, state) VALUES (39.56, 82, 8.03, 'edge');
INSERT INTO stats_logs (ratio, level, weight, state) VALUES (20.96, 84, 69.22, 'strict');
