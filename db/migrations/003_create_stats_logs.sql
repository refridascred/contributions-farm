-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    rank INTEGER,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, label, rank, weight, token) VALUES ('standard', 'strict', 79, 51.24, 'standard');
INSERT INTO stats_logs (region, label, rank, weight, token) VALUES ('latest', 'stable', 96, 47.43, 'green');
INSERT INTO stats_logs (region, label, rank, weight, token) VALUES ('legacy', 'stable', 48, 1.69, 'green');
