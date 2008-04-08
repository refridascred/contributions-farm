-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (region, label, active) VALUES ('staging', 'open', 58);
INSERT INTO stats_logs (region, label, active) VALUES ('primary', 'staging', 90);
INSERT INTO stats_logs (region, label, active) VALUES ('primary', 'open', 61);
