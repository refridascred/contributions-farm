-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (region, rank, ratio) VALUES ('green', 89, 56.82);
INSERT INTO stats_logs (region, rank, ratio) VALUES ('legacy', 44, 12.73);
