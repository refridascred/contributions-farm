-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, token, level, owner) VALUES ('staging', 'open', 17, 'open');
INSERT INTO commits_records (label, token, level, owner) VALUES ('blue', 'latest', 43, 'blue');
