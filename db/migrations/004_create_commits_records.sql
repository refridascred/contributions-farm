-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (token, label, active, region, owner) VALUES ('strict', 'legacy', 54, 'primary', 'stable');
INSERT INTO commits_records (token, label, active, region, owner) VALUES ('primary', 'cached', 3, 'cached', 'edge');
INSERT INTO commits_records (token, label, active, region, owner) VALUES ('green', 'edge', 46, 'strict', 'local');
