-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (owner, weight, count, ratio) VALUES ('primary', 27.04, 37, 29.1);
INSERT INTO stats_logs (owner, weight, count, ratio) VALUES ('cached', 49.43, 98, 63.27);
INSERT INTO stats_logs (owner, weight, count, ratio) VALUES ('stable', 9.22, 41, 90.81);
