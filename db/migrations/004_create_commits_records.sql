-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, state, active) VALUES ('legacy', 'blue', 43);
INSERT INTO commits_records (region, state, active) VALUES ('cached', 'primary', 77);
INSERT INTO commits_records (region, state, active) VALUES ('eu-west', 'open', 98);
