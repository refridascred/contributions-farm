-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (token, owner, score, label) VALUES ('local', 'green', 61.38, 'stable');
INSERT INTO stats_logs (token, owner, score, label) VALUES ('open', 'strict', 15.54, 'cached');
INSERT INTO stats_logs (token, owner, score, label) VALUES ('open', 'strict', 93.05, 'blue');
