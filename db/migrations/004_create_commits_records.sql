-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (level, label, token, owner) VALUES (69, 'eu-west', 'blue', 'staging');
INSERT INTO commits_records (level, label, token, owner) VALUES (16, 'staging', 'legacy', 'local');
