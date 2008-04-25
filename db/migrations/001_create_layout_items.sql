-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, state, count) VALUES (5.27, 'fallback', 26);
INSERT INTO layout_items (weight, state, count) VALUES (10.41, 'standard', 37);
INSERT INTO layout_items (weight, state, count) VALUES (68.61, 'latest', 48);
