-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (ratio, level, active, region, score) VALUES (68.95, 40, 62, 'latest', 87.77);
INSERT INTO stats_logs (ratio, level, active, region, score) VALUES (7.22, 26, 91, 'primary', 76.54);
INSERT INTO stats_logs (ratio, level, active, region, score) VALUES (73.61, 32, 96, 'eu-west', 53.03);
