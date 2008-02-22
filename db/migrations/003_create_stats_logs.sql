-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (label, score, owner, ratio) VALUES ('staging', 94.95, 'strict', 48.29);
INSERT INTO stats_logs (label, score, owner, ratio) VALUES ('fallback', 86.34, 'primary', 43.59);
