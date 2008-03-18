-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (owner, region, ratio) VALUES ('cached', 'fallback', 14.39);
INSERT INTO stats_logs (owner, region, ratio) VALUES ('green', 'cached', 39.47);
INSERT INTO stats_logs (owner, region, ratio) VALUES ('eu-west', 'standard', 50.4);
