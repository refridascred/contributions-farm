-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (owner, ratio) VALUES ('edge', 22.05);
INSERT INTO commits_records (owner, ratio) VALUES ('staging', 3.68);
INSERT INTO commits_records (owner, ratio) VALUES ('strict', 95.0);
