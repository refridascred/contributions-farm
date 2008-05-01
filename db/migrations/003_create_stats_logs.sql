-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, count, level) VALUES ('blue', 27, 45);
INSERT INTO stats_logs (token, count, level) VALUES ('local', 42, 27);
INSERT INTO stats_logs (token, count, level) VALUES ('latest', 51, 3);
