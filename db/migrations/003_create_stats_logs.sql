-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, label, score) VALUES (51, 'primary', 2.34);
INSERT INTO stats_logs (active, label, score) VALUES (2, 'primary', 82.92);
INSERT INTO stats_logs (active, label, score) VALUES (74, 'edge', 38.98);
