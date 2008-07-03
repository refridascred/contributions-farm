-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (weight, owner, ratio) VALUES (8.43, 'eu-west', 69.64);
INSERT INTO stats_logs (weight, owner, ratio) VALUES (71.88, 'primary', 72.04);
