-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, active, weight) VALUES ('local', 28, 9.78);
INSERT INTO stats_logs (label, active, weight) VALUES ('standard', 24, 65.18);
INSERT INTO stats_logs (label, active, weight) VALUES ('primary', 55, 65.89);
