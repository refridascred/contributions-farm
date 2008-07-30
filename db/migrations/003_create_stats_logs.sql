-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, level, active, weight) VALUES ('local', 61, 34, 65.67);
INSERT INTO stats_logs (token, level, active, weight) VALUES ('latest', 0, 1, 95.23);
INSERT INTO stats_logs (token, level, active, weight) VALUES ('legacy', 71, 23, 59.01);
