-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (level, count) VALUES (20, 12);
INSERT INTO stats_logs (level, count) VALUES (84, 22);
INSERT INTO stats_logs (level, count) VALUES (26, 29);
