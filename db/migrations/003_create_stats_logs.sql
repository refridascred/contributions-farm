-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (ratio, owner, score, count, label) VALUES (76.94, 'primary', 3.9, 91, 'open');
INSERT INTO stats_logs (ratio, owner, score, count, label) VALUES (26.67, 'edge', 34.36, 62, 'standard');
INSERT INTO stats_logs (ratio, owner, score, count, label) VALUES (56.41, 'edge', 0.3, 60, 'legacy');
