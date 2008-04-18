-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (label, token, owner, rank) VALUES ('local', 'legacy', 'cached', 87);
INSERT INTO commits_records (label, token, owner, rank) VALUES ('stable', 'open', 'fallback', 43);
INSERT INTO commits_records (label, token, owner, rank) VALUES ('eu-west', 'edge', 'eu-west', 16);
