-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (token, level, score, label) VALUES ('eu-west', 70, 18.83, 'open');
INSERT INTO stats_logs (token, level, score, label) VALUES ('edge', 5, 54.12, 'standard');
