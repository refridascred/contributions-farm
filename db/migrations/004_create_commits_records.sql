-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    token TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (count, region, token, owner, active) VALUES (49, 'strict', 'eu-west', 'blue', 59);
INSERT INTO commits_records (count, region, token, owner, active) VALUES (69, 'latest', 'local', 'eu-west', 11);
INSERT INTO commits_records (count, region, token, owner, active) VALUES (27, 'primary', 'local', 'eu-west', 62);
