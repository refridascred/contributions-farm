-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (weight, owner, rank) VALUES (42.87, 'edge', 19);
INSERT INTO stats_logs (weight, owner, rank) VALUES (96.75, 'legacy', 88);
INSERT INTO stats_logs (weight, owner, rank) VALUES (67.12, 'eu-west', 66);
