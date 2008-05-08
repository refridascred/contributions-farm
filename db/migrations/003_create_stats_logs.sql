-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (owner, count, label, token) VALUES ('strict', 93, 'stable', 'blue');
INSERT INTO stats_logs (owner, count, label, token) VALUES ('latest', 56, 'standard', 'edge');
INSERT INTO stats_logs (owner, count, label, token) VALUES ('cached', 31, 'standard', 'cached');
