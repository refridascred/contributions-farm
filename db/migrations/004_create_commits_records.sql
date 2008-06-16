-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (region, label, owner, count, state) VALUES ('local', 'eu-west', 'local', 77, 'cached');
INSERT INTO commits_records (region, label, owner, count, state) VALUES ('strict', 'open', 'legacy', 55, 'edge');
