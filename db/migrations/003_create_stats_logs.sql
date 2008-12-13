-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    level INTEGER,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (weight, level, label, count) VALUES (59.5, 27, 'legacy', 63);
INSERT INTO stats_logs (weight, level, label, count) VALUES (36.07, 51, 'staging', 31);
