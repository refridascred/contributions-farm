-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    region TEXT,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (label, token, region, owner, level) VALUES ('latest', 'local', 'cached', 'open', 72);
INSERT INTO commits_records (label, token, region, owner, level) VALUES ('eu-west', 'fallback', 'eu-west', 'cached', 1);
INSERT INTO commits_records (label, token, region, owner, level) VALUES ('staging', 'eu-west', 'edge', 'green', 20);
