-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (level, score, count, label) VALUES (15, 4.9, 30, 'open');
INSERT INTO stats_logs (level, score, count, label) VALUES (61, 83.72, 49, 'staging');
INSERT INTO stats_logs (level, score, count, label) VALUES (27, 11.26, 76, 'staging');
