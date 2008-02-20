-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, count, state) VALUES ('fallback', 77, 'strict');
INSERT INTO commits_records (region, count, state) VALUES ('cached', 35, 'edge');
INSERT INTO commits_records (region, count, state) VALUES ('cached', 60, 'standard');
