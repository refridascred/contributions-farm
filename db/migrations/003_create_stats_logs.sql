-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (token, weight, count) VALUES ('fallback', 90.0, 68);
INSERT INTO stats_logs (token, weight, count) VALUES ('green', 52.15, 5);
INSERT INTO stats_logs (token, weight, count) VALUES ('cached', 87.51, 56);
