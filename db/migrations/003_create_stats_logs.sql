-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (ratio, owner, weight) VALUES (92.05, 'standard', 41.01);
INSERT INTO stats_logs (ratio, owner, weight) VALUES (45.57, 'open', 59.48);
INSERT INTO stats_logs (ratio, owner, weight) VALUES (41.89, 'latest', 4.9);
