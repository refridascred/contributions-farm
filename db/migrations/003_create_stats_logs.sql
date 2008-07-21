-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (state, owner, count, rank) VALUES ('latest', 'latest', 58, 88);
INSERT INTO stats_logs (state, owner, count, rank) VALUES ('local', 'edge', 37, 68);
INSERT INTO stats_logs (state, owner, count, rank) VALUES ('staging', 'open', 42, 63);
