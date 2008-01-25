-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (token, level, owner, ratio) VALUES ('cached', 79, 'green', 71.43);
