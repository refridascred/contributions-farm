-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    owner TEXT NOT NULL,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (label, rank, owner, weight, ratio) VALUES ('open', 19, 'edge', 8.17, 30.66);
INSERT INTO stats_logs (label, rank, owner, weight, ratio) VALUES ('primary', 75, 'cached', 43.2, 67.0);
INSERT INTO stats_logs (label, rank, owner, weight, ratio) VALUES ('strict', 15, 'blue', 25.65, 22.4);
