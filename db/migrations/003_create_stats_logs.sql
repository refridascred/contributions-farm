-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (region, rank, token) VALUES ('legacy', 4, 'strict');
INSERT INTO stats_logs (region, rank, token) VALUES ('latest', 51, 'green');
INSERT INTO stats_logs (region, rank, token) VALUES ('standard', 22, 'stable');
