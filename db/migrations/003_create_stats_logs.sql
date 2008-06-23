-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (level, weight, active, label, score) VALUES (9, 6.52, 18, 'fallback', 89.45);
INSERT INTO stats_logs (level, weight, active, label, score) VALUES (76, 25.2, 44, 'staging', 4.54);
INSERT INTO stats_logs (level, weight, active, label, score) VALUES (31, 8.42, 97, 'standard', 16.74);
