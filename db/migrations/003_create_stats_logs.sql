-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    level INTEGER,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (token, region, level, weight, rank) VALUES ('blue', 'legacy', 75, 89.89, 7);
INSERT INTO stats_logs (token, region, level, weight, rank) VALUES ('primary', 'latest', 49, 80.14, 17);
INSERT INTO stats_logs (token, region, level, weight, rank) VALUES ('eu-west', 'strict', 0, 48.26, 46);
