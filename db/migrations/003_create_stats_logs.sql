-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (rank, active, count, level, label) VALUES (59, 27, 80, 2, 'green');
INSERT INTO stats_logs (rank, active, count, level, label) VALUES (10, 35, 86, 20, 'fallback');
INSERT INTO stats_logs (rank, active, count, level, label) VALUES (86, 92, 97, 38, 'blue');
