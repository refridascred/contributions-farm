-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (count, ratio, rank, token) VALUES (57, 52.47, 28, 'eu-west');
INSERT INTO commits_records (count, ratio, rank, token) VALUES (29, 65.16, 43, 'primary');
