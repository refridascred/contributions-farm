-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (owner, level, token) VALUES ('stable', 57, 'staging');
INSERT INTO stats_logs (owner, level, token) VALUES ('stable', 37, 'strict');
INSERT INTO stats_logs (owner, level, token) VALUES ('blue', 35, 'standard');
