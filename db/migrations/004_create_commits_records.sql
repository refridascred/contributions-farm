-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, label, state) VALUES ('edge', 'strict', 'legacy');
INSERT INTO commits_records (region, label, state) VALUES ('green', 'local', 'strict');
INSERT INTO commits_records (region, label, state) VALUES ('blue', 'standard', 'local');
