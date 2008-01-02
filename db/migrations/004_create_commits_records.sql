-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (rank, owner, label) VALUES (75, 'latest', 'open');
INSERT INTO commits_records (rank, owner, label) VALUES (40, 'eu-west', 'blue');
