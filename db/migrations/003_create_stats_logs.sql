-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    created_at TIMESTAMP,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (label, token, weight, owner) VALUES ('fallback', 'green', 37.38, 'blue');
INSERT INTO stats_logs (label, token, weight, owner) VALUES ('local', 'strict', 0.41, 'blue');
