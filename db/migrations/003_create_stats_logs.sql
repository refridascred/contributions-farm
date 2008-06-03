-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (level, state, active, region) VALUES (3, 'standard', 43, 'cached');
INSERT INTO stats_logs (level, state, active, region) VALUES (0, 'latest', 92, 'legacy');
