-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (state, count, region, label) VALUES ('eu-west', 61, 'stable', 'edge');
INSERT INTO commits_records (state, count, region, label) VALUES ('fallback', 70, 'fallback', 'eu-west');
INSERT INTO commits_records (state, count, region, label) VALUES ('blue', 71, 'strict', 'stable');
