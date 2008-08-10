-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, owner, score, label, active) VALUES (36.42, 'latest', 54.27, 'primary', 47);
INSERT INTO stats_logs (ratio, owner, score, label, active) VALUES (85.11, 'eu-west', 37.73, 'fallback', 52);
INSERT INTO stats_logs (ratio, owner, score, label, active) VALUES (0.68, 'open', 10.0, 'local', 82);
