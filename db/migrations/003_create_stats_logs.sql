-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    created_at TIMESTAMP,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (token, weight, level, rank) VALUES ('staging', 88.78, 20, 61);
INSERT INTO stats_logs (token, weight, level, rank) VALUES ('edge', 13.8, 51, 21);
INSERT INTO stats_logs (token, weight, level, rank) VALUES ('standard', 87.42, 69, 57);
