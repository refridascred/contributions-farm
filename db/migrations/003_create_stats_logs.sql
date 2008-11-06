-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (level, score, owner, label) VALUES (63, 8.84, 'eu-west', 'edge');
INSERT INTO stats_logs (level, score, owner, label) VALUES (6, 38.56, 'staging', 'primary');
