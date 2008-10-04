-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (token, rank, owner) VALUES ('open', 64, 'local');
INSERT INTO commits_records (token, rank, owner) VALUES ('primary', 27, 'open');
INSERT INTO commits_records (token, rank, owner) VALUES ('primary', 50, 'eu-west');
