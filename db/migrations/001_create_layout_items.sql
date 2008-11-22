-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (state, ratio, score, owner) VALUES ('edge', 36.15, 56.3, 'latest');
INSERT INTO layout_items (state, ratio, score, owner) VALUES ('cached', 1.58, 87.65, 'blue');
INSERT INTO layout_items (state, ratio, score, owner) VALUES ('fallback', 42.43, 18.42, 'stable');
