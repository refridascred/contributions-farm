-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (active, owner, weight) VALUES (79, 'edge', 77.92);
INSERT INTO stats_logs (active, owner, weight) VALUES (77, 'stable', 12.66);
INSERT INTO stats_logs (active, owner, weight) VALUES (95, 'blue', 17.82);
