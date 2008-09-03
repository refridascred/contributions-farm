-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (owner, weight, token) VALUES ('staging', 77.7, 'green');
INSERT INTO commits_records (owner, weight, token) VALUES ('staging', 87.77, 'edge');
INSERT INTO commits_records (owner, weight, token) VALUES ('staging', 70.3, 'fallback');
