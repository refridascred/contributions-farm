-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (rank, owner, ratio, weight) VALUES (35, 'staging', 37.73, 85.11);
INSERT INTO stats_logs (rank, owner, ratio, weight) VALUES (49, 'primary', 53.96, 87.02);
INSERT INTO stats_logs (rank, owner, ratio, weight) VALUES (87, 'blue', 26.36, 88.95);
