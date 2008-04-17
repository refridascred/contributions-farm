-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (owner, level, region, score) VALUES ('primary', 30, 'latest', 59.99);
INSERT INTO stats_logs (owner, level, region, score) VALUES ('green', 96, 'strict', 48.45);
