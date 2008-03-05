-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (owner, active, rank, count, ratio) VALUES ('fallback', 93, 31, 72, 62.22);
INSERT INTO commits_records (owner, active, rank, count, ratio) VALUES ('cached', 19, 21, 6, 46.56);
