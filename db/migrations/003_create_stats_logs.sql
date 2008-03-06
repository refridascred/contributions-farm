-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (active, level, label, count, token) VALUES (24, 30, 'staging', 25, 'blue');
INSERT INTO stats_logs (active, level, label, count, token) VALUES (76, 92, 'legacy', 24, 'fallback');
INSERT INTO stats_logs (active, level, label, count, token) VALUES (71, 75, 'cached', 18, 'latest');
