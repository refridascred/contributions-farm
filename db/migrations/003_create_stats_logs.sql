-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (rank, token, weight) VALUES (75, 'primary', 42.5);
INSERT INTO stats_logs (rank, token, weight) VALUES (94, 'eu-west', 86.06);
INSERT INTO stats_logs (rank, token, weight) VALUES (1, 'primary', 60.23);
