-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (score, owner, region, level) VALUES (42.34, 'standard', 'blue', 96);
INSERT INTO stats_logs (score, owner, region, level) VALUES (59.78, 'strict', 'eu-west', 82);
INSERT INTO stats_logs (score, owner, region, level) VALUES (76.76, 'open', 'staging', 31);
