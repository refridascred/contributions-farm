-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    token TEXT,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (weight, level, token, owner, label) VALUES (81.43, 7, 'local', 'local', 'blue');
INSERT INTO commits_records (weight, level, token, owner, label) VALUES (87.16, 67, 'open', 'strict', 'strict');
