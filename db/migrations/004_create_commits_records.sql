-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    rank INTEGER,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (count, owner, rank, token, label) VALUES (94, 'staging', 20, 'edge', 'legacy');
INSERT INTO commits_records (count, owner, rank, token, label) VALUES (77, 'primary', 18, 'latest', 'staging');
INSERT INTO commits_records (count, owner, rank, token, label) VALUES (95, 'eu-west', 39, 'local', 'fallback');
