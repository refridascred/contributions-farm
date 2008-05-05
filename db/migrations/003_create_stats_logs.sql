-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, count, ratio) VALUES (45, 2, 50.28);
INSERT INTO stats_logs (active, count, ratio) VALUES (70, 20, 83.02);
INSERT INTO stats_logs (active, count, ratio) VALUES (33, 1, 69.53);
