-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (count, ratio, rank, label) VALUES (81, 53.82, 22, 'legacy');
INSERT INTO stats_logs (count, ratio, rank, label) VALUES (61, 78.19, 18, 'local');
