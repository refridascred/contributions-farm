-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (label, level, score, token) VALUES ('staging', 42, 80.31, 'staging');
INSERT INTO stats_logs (label, level, score, token) VALUES ('standard', 26, 26.81, 'edge');
