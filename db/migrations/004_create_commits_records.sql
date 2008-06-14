-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (state, label, region, active) VALUES ('eu-west', 'edge', 'standard', 2);
INSERT INTO commits_records (state, label, region, active) VALUES ('strict', 'fallback', 'blue', 95);
