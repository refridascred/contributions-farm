-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (token, owner, label, level) VALUES ('standard', 'green', 'blue', 53);
INSERT INTO commits_records (token, owner, label, level) VALUES ('blue', 'stable', 'fallback', 78);
