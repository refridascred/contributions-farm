-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (level, token, weight) VALUES (94, 'local', 54.65);
INSERT INTO stats_logs (level, token, weight) VALUES (44, 'eu-west', 13.92);
