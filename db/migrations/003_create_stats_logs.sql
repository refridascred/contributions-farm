-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (ratio, owner, level) VALUES (72.97, 'primary', 74);
INSERT INTO stats_logs (ratio, owner, level) VALUES (8.95, 'standard', 48);
