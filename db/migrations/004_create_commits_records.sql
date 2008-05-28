-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (region, label, owner, score) VALUES ('fallback', 'staging', 'standard', 50.41);
INSERT INTO commits_records (region, label, owner, score) VALUES ('eu-west', 'open', 'open', 28.82);
