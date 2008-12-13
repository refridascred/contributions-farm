-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (count, state, owner, rank) VALUES (70, 'eu-west', 'fallback', 58);
INSERT INTO stats_logs (count, state, owner, rank) VALUES (11, 'strict', 'stable', 97);
INSERT INTO stats_logs (count, state, owner, rank) VALUES (99, 'latest', 'latest', 77);
