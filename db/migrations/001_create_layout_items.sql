-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (count, weight, label) VALUES (5, 22.97, 'strict');
INSERT INTO layout_items (count, weight, label) VALUES (78, 26.0, 'blue');
INSERT INTO layout_items (count, weight, label) VALUES (25, 25.21, 'latest');
