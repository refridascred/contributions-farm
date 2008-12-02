-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    region TEXT,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (label, region, rank, owner) VALUES ('legacy', 'primary', 37, 'open');
INSERT INTO commits_records (label, region, rank, owner) VALUES ('strict', 'latest', 49, 'standard');
