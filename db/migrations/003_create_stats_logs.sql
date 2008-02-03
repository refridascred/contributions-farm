-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (score, owner, label) VALUES (9.6, 'staging', 'eu-west');
INSERT INTO stats_logs (score, owner, label) VALUES (64.68, 'staging', 'cached');
