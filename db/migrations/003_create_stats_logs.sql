-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    rank INTEGER,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (weight, rank, region, state) VALUES (57.76, 53, 'blue', 'stable');
INSERT INTO stats_logs (weight, rank, region, state) VALUES (37.62, 96, 'latest', 'primary');
INSERT INTO stats_logs (weight, rank, region, state) VALUES (16.03, 37, 'green', 'local');
