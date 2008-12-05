-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, label, owner) VALUES (88.88, 'staging', 'green');
INSERT INTO stats_logs (ratio, label, owner) VALUES (47.88, 'stable', 'local');
