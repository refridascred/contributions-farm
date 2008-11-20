-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (label, level, active, ratio) VALUES ('stable', 1, 56, 71.72);
INSERT INTO stats_logs (label, level, active, ratio) VALUES ('blue', 8, 75, 0.45);
INSERT INTO stats_logs (label, level, active, ratio) VALUES ('latest', 41, 91, 80.67);
