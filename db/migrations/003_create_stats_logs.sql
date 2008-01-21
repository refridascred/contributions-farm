-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    weight REAL,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (label, rank, weight, ratio) VALUES ('primary', 78, 96.09, 20.62);
INSERT INTO stats_logs (label, rank, weight, ratio) VALUES ('primary', 47, 41.1, 89.65);
