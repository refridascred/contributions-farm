-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (owner, rank, active) VALUES ('standard', 47, 33);
INSERT INTO commits_records (owner, rank, active) VALUES ('open', 2, 61);
INSERT INTO commits_records (owner, rank, active) VALUES ('green', 20, 31);
