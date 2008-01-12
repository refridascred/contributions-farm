-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (score, owner) VALUES (18.61, 'primary');
INSERT INTO commits_records (score, owner) VALUES (55.95, 'blue');
INSERT INTO commits_records (score, owner) VALUES (83.39, 'blue');
