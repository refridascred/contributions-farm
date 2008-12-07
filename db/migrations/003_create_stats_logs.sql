-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (token, owner, level, score, label) VALUES ('fallback', 'fallback', 64, 65.43, 'eu-west');
INSERT INTO stats_logs (token, owner, level, score, label) VALUES ('edge', 'open', 8, 51.77, 'staging');
INSERT INTO stats_logs (token, owner, level, score, label) VALUES ('staging', 'eu-west', 65, 74.35, 'local');
