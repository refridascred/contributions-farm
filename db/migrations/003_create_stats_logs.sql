-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (weight, owner, token, count, label) VALUES (61.84, 'open', 'green', 85, 'latest');
INSERT INTO stats_logs (weight, owner, token, count, label) VALUES (20.93, 'legacy', 'open', 80, 'open');
