-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (owner, active, count, rank, label) VALUES ('blue', 16, 79, 13, 'legacy');
INSERT INTO commits_records (owner, active, count, rank, label) VALUES ('eu-west', 77, 11, 71, 'eu-west');
INSERT INTO commits_records (owner, active, count, rank, label) VALUES ('open', 8, 22, 85, 'eu-west');
