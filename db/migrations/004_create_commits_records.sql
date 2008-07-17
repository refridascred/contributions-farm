-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, state, label, count) VALUES ('standard', 'stable', 'latest', 34);
INSERT INTO commits_records (region, state, label, count) VALUES ('standard', 'blue', 'fallback', 85);
INSERT INTO commits_records (region, state, label, count) VALUES ('legacy', 'blue', 'local', 13);
