-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (weight, label, ratio) VALUES (64.33, 'fallback', 59.03);
INSERT INTO layout_items (weight, label, ratio) VALUES (93.56, 'green', 72.69);
