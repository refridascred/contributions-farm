-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (score, label, count, token) VALUES (24.45, 'standard', 71, 'strict');
INSERT INTO stats_logs (score, label, count, token) VALUES (77.03, 'blue', 55, 'latest');
INSERT INTO stats_logs (score, label, count, token) VALUES (36.45, 'legacy', 23, 'local');
