-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    region TEXT,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (state, rank, region, active) VALUES ('legacy', 57, 'green', 60);
INSERT INTO stats_logs (state, rank, region, active) VALUES ('stable', 98, 'stable', 26);
INSERT INTO stats_logs (state, rank, region, active) VALUES ('stable', 85, 'stable', 3);
