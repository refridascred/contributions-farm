-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (rank, weight, owner) VALUES (66, 16.88, 'edge');
INSERT INTO commits_records (rank, weight, owner) VALUES (9, 26.94, 'open');
INSERT INTO commits_records (rank, weight, owner) VALUES (76, 71.89, 'local');
