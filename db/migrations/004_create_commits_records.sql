-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (active, token, owner, score) VALUES (88, 'cached', 'edge', 45.1);
INSERT INTO commits_records (active, token, owner, score) VALUES (66, 'strict', 'latest', 50.66);
INSERT INTO commits_records (active, token, owner, score) VALUES (44, 'blue', 'latest', 80.84);
