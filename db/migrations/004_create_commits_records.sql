-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    ratio REAL,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (rank, label, ratio, owner, token) VALUES (36, 'green', 56.12, 'standard', 'open');
INSERT INTO commits_records (rank, label, ratio, owner, token) VALUES (71, 'open', 5.72, 'legacy', 'blue');
INSERT INTO commits_records (rank, label, ratio, owner, token) VALUES (93, 'local', 98.95, 'cached', 'edge');
