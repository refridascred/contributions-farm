-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, owner, ratio, score, count) VALUES (65, 'standard', 63.91, 55.78, 7);
INSERT INTO stats_logs (active, owner, ratio, score, count) VALUES (80, 'open', 34.42, 65.67, 81);
INSERT INTO stats_logs (active, owner, ratio, score, count) VALUES (77, 'strict', 6.04, 48.64, 43);
