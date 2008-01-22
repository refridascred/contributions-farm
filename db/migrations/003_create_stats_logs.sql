-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (ratio, score, owner, label) VALUES (25.56, 97.26, 'staging', 'strict');
INSERT INTO stats_logs (ratio, score, owner, label) VALUES (19.3, 55.66, 'local', 'latest');
INSERT INTO stats_logs (ratio, score, owner, label) VALUES (93.71, 25.16, 'fallback', 'blue');
