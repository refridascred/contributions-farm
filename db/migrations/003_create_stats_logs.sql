-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (region, count, token, active, label) VALUES ('primary', 40, 'blue', 64, 'stable');
INSERT INTO stats_logs (region, count, token, active, label) VALUES ('cached', 59, 'local', 17, 'fallback');
