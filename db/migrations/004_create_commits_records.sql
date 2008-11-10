-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (level, label, owner) VALUES (68, 'eu-west', 'standard');
INSERT INTO commits_records (level, label, owner) VALUES (80, 'local', 'cached');
INSERT INTO commits_records (level, label, owner) VALUES (66, 'latest', 'legacy');
