-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (token, level, active, label) VALUES ('primary', 76, 92, 'fallback');
INSERT INTO stats_logs (token, level, active, label) VALUES ('primary', 10, 44, 'legacy');
INSERT INTO stats_logs (token, level, active, label) VALUES ('blue', 37, 21, 'strict');
