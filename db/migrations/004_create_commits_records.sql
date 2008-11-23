-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (region, score, state, owner) VALUES ('standard', 36.89, 'eu-west', 'standard');
INSERT INTO commits_records (region, score, state, owner) VALUES ('strict', 17.5, 'green', 'open');
INSERT INTO commits_records (region, score, state, owner) VALUES ('primary', 27.11, 'standard', 'staging');
