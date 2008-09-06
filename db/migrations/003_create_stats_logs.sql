-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, level, rank) VALUES (43, 32, 34);
INSERT INTO stats_logs (count, level, rank) VALUES (45, 56, 81);
INSERT INTO stats_logs (count, level, rank) VALUES (39, 62, 8);
