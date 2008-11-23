-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (score, level, owner) VALUES (60.81, 60, 'fallback');
INSERT INTO stats_logs (score, level, owner) VALUES (43.71, 1, 'legacy');
INSERT INTO stats_logs (score, level, owner) VALUES (4.0, 56, 'stable');
