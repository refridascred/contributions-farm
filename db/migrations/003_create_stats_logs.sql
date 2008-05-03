-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (ratio, active, label, weight) VALUES (45.86, 58, 'primary', 14.54);
INSERT INTO stats_logs (ratio, active, label, weight) VALUES (33.86, 55, 'eu-west', 12.37);
