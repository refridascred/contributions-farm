-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (state, region, ratio) VALUES ('green', 'open', 49.22);
INSERT INTO commits_records (state, region, ratio) VALUES ('strict', 'eu-west', 92.27);
