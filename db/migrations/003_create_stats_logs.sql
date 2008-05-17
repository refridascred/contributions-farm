-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (token, owner, weight, level) VALUES ('green', 'legacy', 80.41, 15);
INSERT INTO stats_logs (token, owner, weight, level) VALUES ('strict', 'latest', 54.63, 15);
INSERT INTO stats_logs (token, owner, weight, level) VALUES ('eu-west', 'stable', 68.88, 61);
