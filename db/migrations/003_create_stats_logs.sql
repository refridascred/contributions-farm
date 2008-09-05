-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (state, region, active, level, token) VALUES ('blue', 'primary', 2, 31, 'legacy');
INSERT INTO stats_logs (state, region, active, level, token) VALUES ('primary', 'staging', 24, 14, 'fallback');
