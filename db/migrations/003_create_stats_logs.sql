-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (region, level, token, ratio) VALUES ('staging', 11, 'strict', 64.26);
INSERT INTO stats_logs (region, level, token, ratio) VALUES ('fallback', 5, 'strict', 19.13);
INSERT INTO stats_logs (region, level, token, ratio) VALUES ('strict', 12, 'open', 48.84);
