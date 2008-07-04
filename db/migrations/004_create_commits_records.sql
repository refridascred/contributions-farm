-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (score, rank, owner, active) VALUES (17.75, 30, 'primary', 55);
INSERT INTO commits_records (score, rank, owner, active) VALUES (14.64, 1, 'local', 81);
INSERT INTO commits_records (score, rank, owner, active) VALUES (90.09, 63, 'primary', 69);
