-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, token, level, score, owner) VALUES (31.78, 'standard', 60, 21.15, 'staging');
INSERT INTO stats_logs (ratio, token, level, score, owner) VALUES (87.89, 'open', 45, 89.2, 'stable');
INSERT INTO stats_logs (ratio, token, level, score, owner) VALUES (13.67, 'cached', 87, 62.0, 'fallback');
