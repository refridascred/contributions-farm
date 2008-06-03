-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    weight REAL,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (score, level, weight, label, owner) VALUES (58.94, 56, 98.59, 'open', 'eu-west');
INSERT INTO stats_logs (score, level, weight, label, owner) VALUES (62.45, 1, 25.88, 'cached', 'open');
