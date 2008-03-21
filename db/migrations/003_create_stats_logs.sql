-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (label, level, ratio) VALUES ('fallback', 97, 97.26);
INSERT INTO stats_logs (label, level, ratio) VALUES ('open', 90, 28.39);
