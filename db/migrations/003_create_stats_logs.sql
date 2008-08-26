-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    owner TEXT NOT NULL,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (weight, region, owner, level, token) VALUES (91.0, 'latest', 'open', 21, 'strict');
INSERT INTO stats_logs (weight, region, owner, level, token) VALUES (0.12, 'cached', 'strict', 85, 'green');
INSERT INTO stats_logs (weight, region, owner, level, token) VALUES (91.84, 'fallback', 'cached', 43, 'legacy');
