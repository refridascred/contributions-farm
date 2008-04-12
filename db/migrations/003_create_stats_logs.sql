-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    rank INTEGER,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (label, region, rank, token, level) VALUES ('legacy', 'eu-west', 80, 'cached', 44);
INSERT INTO stats_logs (label, region, rank, token, level) VALUES ('stable', 'edge', 60, 'fallback', 97);
