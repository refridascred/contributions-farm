-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (rank, count, ratio) VALUES (43, 42, 51.01);
INSERT INTO stats_logs (rank, count, ratio) VALUES (48, 8, 32.87);
INSERT INTO stats_logs (rank, count, ratio) VALUES (96, 9, 75.09);
