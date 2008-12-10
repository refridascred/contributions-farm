-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, ratio, rank) VALUES ('green', 98.75, 79);
INSERT INTO stats_logs (owner, ratio, rank) VALUES ('primary', 55.72, 15);
INSERT INTO stats_logs (owner, ratio, rank) VALUES ('latest', 50.78, 66);
