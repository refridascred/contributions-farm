-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (token, level, weight) VALUES ('stable', 98, 68.69);
INSERT INTO stats_logs (token, level, weight) VALUES ('cached', 56, 65.52);
INSERT INTO stats_logs (token, level, weight) VALUES ('fallback', 57, 49.93);
