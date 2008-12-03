-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (label, token, score, level, active) VALUES ('cached', 'staging', 97.08, 29, 87);
INSERT INTO stats_logs (label, token, score, level, active) VALUES ('stable', 'primary', 0.86, 47, 67);
