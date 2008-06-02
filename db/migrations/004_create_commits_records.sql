-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (rank, owner, active) VALUES (42, 'stable', 58);
INSERT INTO commits_records (rank, owner, active) VALUES (7, 'green', 72);
INSERT INTO commits_records (rank, owner, active) VALUES (66, 'legacy', 9);
