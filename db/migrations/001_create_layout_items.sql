-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (weight, label, ratio) VALUES (10.24, 'open', 4.64);
INSERT INTO layout_items (weight, label, ratio) VALUES (56.21, 'green', 94.54);
INSERT INTO layout_items (weight, label, ratio) VALUES (65.08, 'cached', 24.14);
