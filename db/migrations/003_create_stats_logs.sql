-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (level, active, weight) VALUES (53, 13, 90.58);
INSERT INTO stats_logs (level, active, weight) VALUES (45, 18, 23.08);
INSERT INTO stats_logs (level, active, weight) VALUES (54, 96, 31.79);
