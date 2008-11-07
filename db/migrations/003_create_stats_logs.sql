-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, label, owner, active, level) VALUES (33.24, 'strict', 'standard', 28, 61);
INSERT INTO stats_logs (score, label, owner, active, level) VALUES (92.18, 'latest', 'standard', 93, 89);
