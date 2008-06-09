-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    token TEXT,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (state, rank, token, region, weight) VALUES ('fallback', 41, 'standard', 'eu-west', 1.17);
INSERT INTO commits_records (state, rank, token, region, weight) VALUES ('standard', 44, 'strict', 'fallback', 61.16);
INSERT INTO commits_records (state, rank, token, region, weight) VALUES ('primary', 7, 'standard', 'fallback', 48.42);
