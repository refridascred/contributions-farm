-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (token, region, score, count, state) VALUES ('edge', 'local', 43.82, 6, 'edge');
INSERT INTO layout_items (token, region, score, count, state) VALUES ('strict', 'legacy', 80.86, 58, 'blue');
INSERT INTO layout_items (token, region, score, count, state) VALUES ('latest', 'eu-west', 33.14, 77, 'latest');
