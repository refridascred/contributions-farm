-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (label, level, weight) VALUES ('fallback', 98, 21.69);
INSERT INTO stats_logs (label, level, weight) VALUES ('latest', 53, 37.05);
INSERT INTO stats_logs (label, level, weight) VALUES ('local', 97, 39.99);
