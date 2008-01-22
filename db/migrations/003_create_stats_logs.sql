-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (weight, rank, label, level) VALUES (39.51, 18, 'green', 4);
INSERT INTO stats_logs (weight, rank, label, level) VALUES (9.18, 35, 'latest', 89);
