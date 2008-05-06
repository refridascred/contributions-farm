-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, rank) VALUES (90.89, 15);
INSERT INTO stats_logs (ratio, rank) VALUES (47.76, 63);
INSERT INTO stats_logs (ratio, rank) VALUES (18.9, 69);
