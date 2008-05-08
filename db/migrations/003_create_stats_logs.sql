-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (owner, token, ratio, level) VALUES ('strict', 'open', 59.67, 86);
INSERT INTO stats_logs (owner, token, ratio, level) VALUES ('cached', 'edge', 33.7, 13);
