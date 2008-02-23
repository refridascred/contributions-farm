-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (count, weight, score, region, state) VALUES (90, 58.71, 87.26, 'cached', 'eu-west');
INSERT INTO layout_items (count, weight, score, region, state) VALUES (73, 26.02, 94.26, 'green', 'primary');
