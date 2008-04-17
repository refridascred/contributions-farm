-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    label TEXT,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (count, rank, label, token, ratio) VALUES (80, 58, 'cached', 'eu-west', 75.9);
INSERT INTO stats_logs (count, rank, label, token, ratio) VALUES (75, 98, 'latest', 'staging', 20.8);
INSERT INTO stats_logs (count, rank, label, token, ratio) VALUES (89, 6, 'green', 'latest', 58.86);
