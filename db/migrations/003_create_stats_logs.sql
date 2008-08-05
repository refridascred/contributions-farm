-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (score, token, owner, label) VALUES (47.92, 'staging', 'stable', 'stable');
INSERT INTO stats_logs (score, token, owner, label) VALUES (49.19, 'strict', 'latest', 'open');
