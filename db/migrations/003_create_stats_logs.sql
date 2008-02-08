-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    owner TEXT NOT NULL,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (rank, token, owner, level, ratio) VALUES (9, 'green', 'cached', 25, 78.13);
INSERT INTO stats_logs (rank, token, owner, level, ratio) VALUES (9, 'green', 'fallback', 34, 67.5);
