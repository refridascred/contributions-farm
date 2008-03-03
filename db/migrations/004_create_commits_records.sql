-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    region TEXT,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, owner, region, token, score) VALUES ('standard', 'green', 'eu-west', 'standard', 17.37);
INSERT INTO commits_records (label, owner, region, token, score) VALUES ('local', 'green', 'legacy', 'latest', 35.22);
