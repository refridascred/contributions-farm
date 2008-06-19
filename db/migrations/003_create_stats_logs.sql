-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (owner, rank, ratio) VALUES ('primary', 71, 26.38);
INSERT INTO stats_logs (owner, rank, ratio) VALUES ('blue', 36, 27.69);
