-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, label, score) VALUES (48, 'strict', 35.98);
INSERT INTO stats_logs (active, label, score) VALUES (25, 'blue', 53.88);
INSERT INTO stats_logs (active, label, score) VALUES (65, 'latest', 71.67);
