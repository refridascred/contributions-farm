-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (region, state, label, level) VALUES ('cached', 'standard', 'open', 89);
INSERT INTO commits_records (region, state, label, level) VALUES ('latest', 'stable', 'green', 49);
