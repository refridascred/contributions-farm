-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (count, active, weight, score) VALUES (71, 53, 91.41, 71.36);
INSERT INTO stats_logs (count, active, weight, score) VALUES (87, 98, 7.74, 48.19);
INSERT INTO stats_logs (count, active, weight, score) VALUES (52, 24, 14.63, 52.69);
