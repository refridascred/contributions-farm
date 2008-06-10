-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (label, owner, rank, weight) VALUES ('standard', 'staging', 8, 58.59);
INSERT INTO commits_records (label, owner, rank, weight) VALUES ('staging', 'eu-west', 92, 10.19);
INSERT INTO commits_records (label, owner, rank, weight) VALUES ('latest', 'fallback', 43, 51.66);
