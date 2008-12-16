-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (score, state, ratio) VALUES (68.53, 'blue', 40.01);
INSERT INTO layout_items (score, state, ratio) VALUES (97.44, 'legacy', 81.24);
INSERT INTO layout_items (score, state, ratio) VALUES (7.37, 'fallback', 37.91);
