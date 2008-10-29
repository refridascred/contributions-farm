-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, score, label) VALUES (97, 77.03, 'legacy');
INSERT INTO stats_logs (active, score, label) VALUES (36, 49.03, 'stable');
INSERT INTO stats_logs (active, score, label) VALUES (61, 38.23, 'open');
