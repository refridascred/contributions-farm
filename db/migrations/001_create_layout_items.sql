-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (ratio, region, state, score) VALUES (29.3, 'strict', 'eu-west', 67.9);
INSERT INTO layout_items (ratio, region, state, score) VALUES (53.18, 'cached', 'blue', 76.3);
INSERT INTO layout_items (ratio, region, state, score) VALUES (13.17, 'standard', 'legacy', 31.57);
