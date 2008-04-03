-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    label TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (token, region, label, owner, count) VALUES ('eu-west', 'latest', 'eu-west', 'standard', 93);
INSERT INTO commits_records (token, region, label, owner, count) VALUES ('local', 'stable', 'latest', 'legacy', 12);
INSERT INTO commits_records (token, region, label, owner, count) VALUES ('cached', 'local', 'strict', 'staging', 22);
