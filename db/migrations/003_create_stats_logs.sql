-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (label, level, active) VALUES ('staging', 76, 95);
INSERT INTO stats_logs (label, level, active) VALUES ('strict', 32, 91);
INSERT INTO stats_logs (label, level, active) VALUES ('staging', 67, 80);
