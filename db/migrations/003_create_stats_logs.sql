-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (token, count, label, ratio, rank) VALUES ('latest', 46, 'fallback', 85.18, 30);
INSERT INTO stats_logs (token, count, label, ratio, rank) VALUES ('primary', 78, 'blue', 65.78, 66);
INSERT INTO stats_logs (token, count, label, ratio, rank) VALUES ('primary', 65, 'latest', 2.95, 40);
