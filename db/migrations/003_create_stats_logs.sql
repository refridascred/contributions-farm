-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (region, label, ratio) VALUES ('open', 'staging', 72.52);
INSERT INTO stats_logs (region, label, ratio) VALUES ('stable', 'cached', 72.57);
INSERT INTO stats_logs (region, label, ratio) VALUES ('open', 'standard', 28.23);
