-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (level, score, label, owner, weight) VALUES (3, 40.32, 'cached', 'local', 48.28);
INSERT INTO stats_logs (level, score, label, owner, weight) VALUES (15, 29.27, 'fallback', 'cached', 26.86);
INSERT INTO stats_logs (level, score, label, owner, weight) VALUES (0, 39.47, 'green', 'blue', 75.17);
