-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (region, score, level, token) VALUES ('fallback', 95.15, 2, 'local');
INSERT INTO stats_logs (region, score, level, token) VALUES ('open', 91.89, 14, 'fallback');
INSERT INTO stats_logs (region, score, level, token) VALUES ('strict', 51.76, 5, 'blue');
