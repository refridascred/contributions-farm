-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (score, active, level) VALUES (76.77, 80, 19);
INSERT INTO stats_logs (score, active, level) VALUES (2.92, 97, 97);
INSERT INTO stats_logs (score, active, level) VALUES (63.36, 60, 76);
