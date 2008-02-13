-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (level, ratio, state) VALUES (17, 69.4, 'strict');
INSERT INTO stats_logs (level, ratio, state) VALUES (74, 67.28, 'legacy');
INSERT INTO stats_logs (level, ratio, state) VALUES (10, 19.39, 'standard');
