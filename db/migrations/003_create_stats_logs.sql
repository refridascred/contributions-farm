-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (token, weight, count, ratio) VALUES ('open', 79.81, 58, 13.94);
INSERT INTO stats_logs (token, weight, count, ratio) VALUES ('cached', 76.43, 9, 17.68);
