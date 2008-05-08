-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    token TEXT,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (label, ratio, token, level, owner) VALUES ('blue', 45.2, 'stable', 36, 'cached');
INSERT INTO stats_logs (label, ratio, token, level, owner) VALUES ('cached', 6.92, 'blue', 74, 'cached');
