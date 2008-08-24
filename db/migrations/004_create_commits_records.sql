-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, label, level, owner) VALUES ('primary', 'legacy', 51, 'open');
INSERT INTO commits_records (token, label, level, owner) VALUES ('open', 'staging', 38, 'open');
INSERT INTO commits_records (token, label, level, owner) VALUES ('local', 'strict', 86, 'open');
