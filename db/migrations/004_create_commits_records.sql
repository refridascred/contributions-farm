-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (owner, score, active) VALUES ('green', 90.93, 5);
INSERT INTO commits_records (owner, score, active) VALUES ('stable', 12.84, 83);
INSERT INTO commits_records (owner, score, active) VALUES ('blue', 5.49, 75);
