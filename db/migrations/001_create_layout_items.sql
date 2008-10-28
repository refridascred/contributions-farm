-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (weight, state, ratio) VALUES (19.99, 'fallback', 51.71);
INSERT INTO layout_items (weight, state, ratio) VALUES (19.53, 'fallback', 32.53);
