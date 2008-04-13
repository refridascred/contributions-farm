-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (label, ratio, active) VALUES ('staging', 96.72, 25);
INSERT INTO stats_logs (label, ratio, active) VALUES ('cached', 17.26, 25);
INSERT INTO stats_logs (label, ratio, active) VALUES ('standard', 75.75, 91);
