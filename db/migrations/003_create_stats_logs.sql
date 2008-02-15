-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (count, score, region, rank, state) VALUES (46, 48.83, 'eu-west', 39, 'open');
INSERT INTO stats_logs (count, score, region, rank, state) VALUES (86, 36.46, 'legacy', 32, 'eu-west');
