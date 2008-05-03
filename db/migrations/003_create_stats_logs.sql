-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (token, weight, rank, label) VALUES ('legacy', 72.44, 48, 'blue');
INSERT INTO stats_logs (token, weight, rank, label) VALUES ('primary', 18.81, 41, 'local');
