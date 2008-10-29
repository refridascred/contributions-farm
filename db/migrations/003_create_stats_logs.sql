-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (region, token, level, label) VALUES ('open', 'strict', 56, 'stable');
INSERT INTO stats_logs (region, token, level, label) VALUES ('stable', 'cached', 14, 'standard');
