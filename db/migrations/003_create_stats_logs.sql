-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (region, count, level, active) VALUES ('cached', 35, 99, 79);
INSERT INTO stats_logs (region, count, level, active) VALUES ('open', 46, 16, 8);
INSERT INTO stats_logs (region, count, level, active) VALUES ('green', 73, 35, 53);
