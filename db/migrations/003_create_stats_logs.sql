-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (level, ratio, owner, state) VALUES (21, 46.27, 'green', 'eu-west');
INSERT INTO stats_logs (level, ratio, owner, state) VALUES (35, 64.71, 'fallback', 'fallback');
INSERT INTO stats_logs (level, ratio, owner, state) VALUES (67, 85.23, 'legacy', 'fallback');
