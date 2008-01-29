-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, rank, score, owner, count) VALUES ('eu-west', 19, 78.31, 'latest', 81);
INSERT INTO stats_logs (state, rank, score, owner, count) VALUES ('local', 27, 16.02, 'cached', 17);
