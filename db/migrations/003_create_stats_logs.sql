-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    rank INTEGER,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (active, level, rank, token, ratio) VALUES (12, 71, 86, 'fallback', 37.49);
INSERT INTO stats_logs (active, level, rank, token, ratio) VALUES (74, 37, 78, 'open', 63.73);
INSERT INTO stats_logs (active, level, rank, token, ratio) VALUES (54, 8, 22, 'open', 24.88);
