-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (state, count, label, rank, region) VALUES ('standard', 45, 'primary', 16, 'standard');
INSERT INTO commits_records (state, count, label, rank, region) VALUES ('latest', 94, 'strict', 64, 'fallback');
