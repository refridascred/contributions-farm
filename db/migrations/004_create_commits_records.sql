-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (token, level, rank, owner) VALUES ('primary', 55, 55, 'stable');
INSERT INTO commits_records (token, level, rank, owner) VALUES ('fallback', 82, 63, 'eu-west');
