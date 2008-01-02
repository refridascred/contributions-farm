-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, weight, active) VALUES ('staging', 28.64, 38);
INSERT INTO stats_logs (label, weight, active) VALUES ('latest', 37.54, 81);
INSERT INTO stats_logs (label, weight, active) VALUES ('local', 52.26, 73);
