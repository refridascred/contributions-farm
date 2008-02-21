-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    owner TEXT NOT NULL,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (rank, level, owner, weight) VALUES (19, 43, 'eu-west', 88.72);
INSERT INTO stats_logs (rank, level, owner, weight) VALUES (6, 33, 'standard', 26.74);
