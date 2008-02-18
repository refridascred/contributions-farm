-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (weight, token, ratio) VALUES (68.63, 'fallback', 82.01);
INSERT INTO layout_items (weight, token, ratio) VALUES (46.7, 'strict', 8.6);
