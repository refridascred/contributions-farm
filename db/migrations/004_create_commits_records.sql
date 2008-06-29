-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (rank, state, region, label, level) VALUES (99, 'latest', 'strict', 'cached', 17);
INSERT INTO commits_records (rank, state, region, label, level) VALUES (93, 'local', 'blue', 'green', 9);
