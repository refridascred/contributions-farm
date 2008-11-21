-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (label, level) VALUES ('legacy', 25);
INSERT INTO stats_logs (label, level) VALUES ('open', 38);
INSERT INTO stats_logs (label, level) VALUES ('stable', 85);
