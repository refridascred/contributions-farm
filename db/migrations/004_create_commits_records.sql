-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    level INTEGER,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (token, owner, level, rank, label) VALUES ('fallback', 'standard', 60, 67, 'cached');
INSERT INTO commits_records (token, owner, level, rank, label) VALUES ('blue', 'stable', 98, 2, 'staging');
