-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (state, label, region, count) VALUES ('edge', 'latest', 'legacy', 54);
INSERT INTO commits_records (state, label, region, count) VALUES ('eu-west', 'stable', 'open', 7);
