-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (region, ratio, owner, score, level) VALUES ('local', 35.09, 'green', 37.59, 54);
INSERT INTO stats_logs (region, ratio, owner, score, level) VALUES ('strict', 72.87, 'standard', 13.65, 34);
INSERT INTO stats_logs (region, ratio, owner, score, level) VALUES ('local', 38.8, 'latest', 1.36, 47);
