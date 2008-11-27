-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (ratio, owner, weight) VALUES (76.89, 'edge', 39.62);
INSERT INTO stats_logs (ratio, owner, weight) VALUES (1.67, 'cached', 95.91);
INSERT INTO stats_logs (ratio, owner, weight) VALUES (59.03, 'staging', 37.02);
