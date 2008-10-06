-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, rank, active, weight) VALUES ('open', 48, 45, 27.44);
INSERT INTO stats_logs (token, rank, active, weight) VALUES ('stable', 88, 70, 62.5);
