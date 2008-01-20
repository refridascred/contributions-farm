-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    rank INTEGER,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, ratio, rank, label, weight) VALUES (84, 83.76, 75, 'stable', 60.57);
INSERT INTO stats_logs (active, ratio, rank, label, weight) VALUES (62, 25.22, 64, 'legacy', 13.33);
INSERT INTO stats_logs (active, ratio, rank, label, weight) VALUES (71, 7.94, 5, 'eu-west', 24.22);
