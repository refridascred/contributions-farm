-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    token TEXT,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (score, weight, token, owner, label) VALUES (40.83, 36.01, 'local', 'strict', 'green');
INSERT INTO stats_logs (score, weight, token, owner, label) VALUES (97.63, 1.21, 'standard', 'strict', 'staging');
