-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (rank, owner, token, level) VALUES (56, 'strict', 'primary', 76);
INSERT INTO commits_records (rank, owner, token, level) VALUES (64, 'strict', 'primary', 61);
INSERT INTO commits_records (rank, owner, token, level) VALUES (49, 'open', 'latest', 43);
