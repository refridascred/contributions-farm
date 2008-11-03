-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, weight, rank) VALUES ('standard', 65.65, 62);
INSERT INTO stats_logs (owner, weight, rank) VALUES ('latest', 51.02, 6);
