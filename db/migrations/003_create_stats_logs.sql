-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (weight, region, rank, owner) VALUES (68.28, 'open', 87, 'fallback');
INSERT INTO stats_logs (weight, region, rank, owner) VALUES (78.87, 'eu-west', 73, 'green');
