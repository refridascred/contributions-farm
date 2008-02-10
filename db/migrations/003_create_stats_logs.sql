-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (owner, rank, weight, ratio) VALUES ('green', 2, 72.76, 71.89);
INSERT INTO stats_logs (owner, rank, weight, ratio) VALUES ('staging', 56, 63.35, 48.92);
