-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, token, ratio) VALUES (61, 'legacy', 54.62);
INSERT INTO stats_logs (active, token, ratio) VALUES (85, 'latest', 54.04);
INSERT INTO stats_logs (active, token, ratio) VALUES (85, 'cached', 79.04);
