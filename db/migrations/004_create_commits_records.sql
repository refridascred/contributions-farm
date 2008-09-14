-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (owner, rank, active) VALUES ('cached', 82, 96);
INSERT INTO commits_records (owner, rank, active) VALUES ('blue', 21, 72);
INSERT INTO commits_records (owner, rank, active) VALUES ('local', 31, 72);
