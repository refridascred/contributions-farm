-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (rank, count, owner) VALUES (49, 66, 'fallback');
INSERT INTO stats_logs (rank, count, owner) VALUES (95, 15, 'primary');
INSERT INTO stats_logs (rank, count, owner) VALUES (4, 20, 'standard');
