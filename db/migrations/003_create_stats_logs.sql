-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (token, level, ratio) VALUES ('strict', 20, 21.07);
INSERT INTO stats_logs (token, level, ratio) VALUES ('local', 85, 52.47);
INSERT INTO stats_logs (token, level, ratio) VALUES ('strict', 71, 56.07);
