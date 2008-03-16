-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (region, level, ratio, state, token) VALUES ('stable', 5, 75.12, 'strict', 'primary');
INSERT INTO stats_logs (region, level, ratio, state, token) VALUES ('green', 87, 9.63, 'staging', 'standard');
