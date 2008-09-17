-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (score, label, count, level, region) VALUES (22.65, 'standard', 77, 95, 'local');
INSERT INTO stats_logs (score, label, count, level, region) VALUES (27.97, 'strict', 69, 8, 'standard');
