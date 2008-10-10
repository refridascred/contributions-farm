-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (level, token, count) VALUES (88, 'staging', 91);
INSERT INTO stats_logs (level, token, count) VALUES (56, 'eu-west', 18);
INSERT INTO stats_logs (level, token, count) VALUES (91, 'standard', 24);
