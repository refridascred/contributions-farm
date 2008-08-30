-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (active, level, count) VALUES (11, 37, 6);
INSERT INTO stats_logs (active, level, count) VALUES (37, 23, 91);
INSERT INTO stats_logs (active, level, count) VALUES (29, 50, 6);
