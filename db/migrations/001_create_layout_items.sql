-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (score, state, ratio) VALUES (80.62, 'cached', 55.72);
INSERT INTO layout_items (score, state, ratio) VALUES (59.98, 'latest', 14.23);
INSERT INTO layout_items (score, state, ratio) VALUES (93.49, 'open', 75.12);
