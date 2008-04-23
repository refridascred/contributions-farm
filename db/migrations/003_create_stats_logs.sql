-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, rank, score) VALUES ('primary', 7, 46.02);
INSERT INTO stats_logs (owner, rank, score) VALUES ('primary', 8, 95.11);
INSERT INTO stats_logs (owner, rank, score) VALUES ('cached', 57, 81.43);
