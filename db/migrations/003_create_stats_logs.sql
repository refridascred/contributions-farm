-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (level, weight, owner, rank) VALUES (42, 87.44, 'fallback', 82);
INSERT INTO stats_logs (level, weight, owner, rank) VALUES (40, 64.13, 'green', 46);
INSERT INTO stats_logs (level, weight, owner, rank) VALUES (18, 1.87, 'staging', 47);
