-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, level, owner, ratio) VALUES ('eu-west', 84, 'legacy', 87.26);
INSERT INTO stats_logs (region, level, owner, ratio) VALUES ('blue', 66, 'eu-west', 25.31);
