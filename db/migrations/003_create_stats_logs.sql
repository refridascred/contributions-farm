-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    rank INTEGER,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (level, token, rank, ratio) VALUES (31, 'strict', 62, 14.45);
INSERT INTO stats_logs (level, token, rank, ratio) VALUES (66, 'stable', 32, 28.84);
