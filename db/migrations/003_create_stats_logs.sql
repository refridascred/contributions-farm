-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    owner TEXT NOT NULL,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, level, owner, weight, rank) VALUES ('primary', 50, 'local', 92.44, 59);
INSERT INTO stats_logs (region, level, owner, weight, rank) VALUES ('primary', 65, 'strict', 1.32, 38);
INSERT INTO stats_logs (region, level, owner, weight, rank) VALUES ('strict', 26, 'stable', 47.95, 78);
