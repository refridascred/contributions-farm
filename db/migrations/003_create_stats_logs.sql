-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (weight, token, count, owner) VALUES (4.32, 'primary', 76, 'open');
INSERT INTO stats_logs (weight, token, count, owner) VALUES (92.74, 'primary', 25, 'legacy');
