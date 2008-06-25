-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (ratio, level) VALUES (78.22, 64);
INSERT INTO stats_logs (ratio, level) VALUES (68.39, 97);
INSERT INTO stats_logs (ratio, level) VALUES (92.98, 95);
