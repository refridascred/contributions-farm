-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, level, region) VALUES ('legacy', 49, 'blue');
INSERT INTO stats_logs (token, level, region) VALUES ('strict', 85, 'local');
INSERT INTO stats_logs (token, level, region) VALUES ('open', 80, 'local');
