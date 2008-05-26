-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, count, weight, rank) VALUES ('fallback', 78, 80.76, 87);
INSERT INTO stats_logs (token, count, weight, rank) VALUES ('latest', 36, 40.5, 40);
