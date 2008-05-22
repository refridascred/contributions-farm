-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, region, label, rank) VALUES ('blue', 'strict', 'standard', 27);
INSERT INTO commits_records (state, region, label, rank) VALUES ('cached', 'fallback', 'edge', 87);
INSERT INTO commits_records (state, region, label, rank) VALUES ('legacy', 'latest', 'standard', 44);
