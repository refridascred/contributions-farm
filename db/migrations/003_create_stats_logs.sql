-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (owner, ratio, level, token) VALUES ('open', 20.83, 22, 'fallback');
INSERT INTO stats_logs (owner, ratio, level, token) VALUES ('edge', 73.72, 93, 'fallback');
INSERT INTO stats_logs (owner, ratio, level, token) VALUES ('strict', 98.81, 88, 'fallback');
