-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, label, weight, score) VALUES (58, 'strict', 15.99, 55.21);
INSERT INTO stats_logs (active, label, weight, score) VALUES (47, 'local', 0.98, 95.73);
INSERT INTO stats_logs (active, label, weight, score) VALUES (89, 'local', 58.77, 56.92);
