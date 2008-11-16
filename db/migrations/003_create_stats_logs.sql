-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (owner, token, count, label, score) VALUES ('eu-west', 'latest', 77, 'primary', 77.4);
INSERT INTO stats_logs (owner, token, count, label, score) VALUES ('staging', 'fallback', 58, 'cached', 85.06);
