-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (owner, ratio, count, rank) VALUES ('latest', 66.25, 71, 51);
INSERT INTO stats_logs (owner, ratio, count, rank) VALUES ('primary', 0.26, 81, 4);
