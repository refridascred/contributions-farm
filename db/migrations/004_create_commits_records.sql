-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (label, weight, state, region, count) VALUES ('primary', 10.84, 'eu-west', 'open', 81);
INSERT INTO commits_records (label, weight, state, region, count) VALUES ('standard', 4.43, 'latest', 'open', 52);
