-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (region, level, rank, label) VALUES ('local', 9, 85, 'local');
INSERT INTO stats_logs (region, level, rank, label) VALUES ('green', 36, 9, 'standard');
INSERT INTO stats_logs (region, level, rank, label) VALUES ('blue', 38, 32, 'primary');
