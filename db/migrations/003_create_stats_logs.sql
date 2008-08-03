-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (rank, weight, region, count, level) VALUES (4, 46.93, 'strict', 33, 26);
INSERT INTO stats_logs (rank, weight, region, count, level) VALUES (54, 96.61, 'eu-west', 33, 63);
INSERT INTO stats_logs (rank, weight, region, count, level) VALUES (71, 76.93, 'cached', 43, 12);
