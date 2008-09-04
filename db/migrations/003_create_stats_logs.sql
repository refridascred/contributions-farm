-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (score, label, ratio, owner) VALUES (60.46, 'staging', 17.83, 'stable');
INSERT INTO stats_logs (score, label, ratio, owner) VALUES (97.84, 'green', 23.41, 'stable');
INSERT INTO stats_logs (score, label, ratio, owner) VALUES (28.52, 'stable', 57.91, 'staging');
