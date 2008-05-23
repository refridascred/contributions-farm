-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (level, ratio, state) VALUES (37, 18.95, 'standard');
INSERT INTO stats_logs (level, ratio, state) VALUES (45, 74.75, 'open');
INSERT INTO stats_logs (level, ratio, state) VALUES (25, 98.97, 'stable');
