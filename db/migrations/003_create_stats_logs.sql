-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (score, token, level, label) VALUES (34.65, 'staging', 73, 'legacy');
INSERT INTO stats_logs (score, token, level, label) VALUES (30.78, 'eu-west', 95, 'strict');
