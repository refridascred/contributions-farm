-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (owner, token, count, label, score) VALUES ('eu-west', 'green', 58, 'eu-west', 88.45);
INSERT INTO stats_logs (owner, token, count, label, score) VALUES ('fallback', 'primary', 85, 'local', 76.87);
